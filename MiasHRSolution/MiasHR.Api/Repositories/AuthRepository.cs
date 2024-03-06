using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MiasHR.Api.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public AuthRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        public async Task<Tuple<HrEmployee, bool>>? Login(string username, string passwordHash)
        {
            var userCred = await _miasHRDbContext.HrUserCreds
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Username == username);

            if (userCred is null)
            {
                return null;
            }

            // set up log entry
            var logEntry = new HrUserLoginLog
            {
                EmplCode = userCred.EmplCode,
                LoginDate = DateTime.Now,
                AcceptYn = null,
                Remark = null
            };

            if (!BCrypt.Net.BCrypt.Verify(passwordHash, userCred.PasswordHash))
            {
                // log login failure
                logEntry.AcceptYn = "N";
                logEntry.Remark = "Password incorrect";
                await _miasHRDbContext.AddAsync(logEntry);
                await _miasHRDbContext.SaveChangesAsync();

                return null;
            }

            // log login success
            // 2/27/24 MAKE SURE TO CHECK IF IDENTITY PROPERTY IS SET TO SEQ
            logEntry.AcceptYn = "Y";
            await _miasHRDbContext.AddAsync(logEntry);
            await _miasHRDbContext.SaveChangesAsync();

            // get user employee info from database
            var employee = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(x => x.EmplCode == userCred.EmplCode);

            // check if user is manager
            var isManager = false;

            var parameters = new
            {
                pEmplCode = employee.EmplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                var result = await connection.QueryAsync<ManagerEmployeeListDTO>(
                    "sp_HR_ManagerEmployeeList",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                var list = result.ToList();

                if (list.Count != 0)
                {
                    isManager = true;
                }
            }
            
            return new Tuple<HrEmployee, bool>(employee, isManager);
        }

        /// <summary>
        /// Registers a new user with the provided username, password hash, and birthdate.
        /// </summary>
        /// <param name="username">The username to register.</param>
        /// <param name="passwordHash">The hashed password for the user.</param>
        /// <param name="birthDate">The birthdate of the user.</param>
        /// <returns>
        /// A RequestResultDTO representing the result of the registration.
        /// The RequestResultDTO contains a status indicating success or failure, along with additional information.
        /// </returns>
        public async Task<RequestResultDTO> Register(string username, string passwordHash, DateOnly birthDate)
        {
            // Check if the user already exists
            var existingUserCred = await _miasHRDbContext.HrUserCreds
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Username == username && x.Status != 3);

            if (existingUserCred is not null)
            {
                // User already exists, return appropriate message
                return new RequestResultDTO("USER EXISTS", null);
            }

            // Verify that the username is a valid Mias email
            var employee = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.ComEmail == username);

            if (employee is null)
            {
                // Employee email not found, return appropriate message
                return new RequestResultDTO("EMPLOYEE EMAIL NOT FOUND", null);
            }

            // Verify that the birthdate matches the employee record
            var birthDateString = birthDate.ToString("yyyyMMdd");

            var employeeDetail = await _miasHRDbContext.HrEmployeeDetails
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.EmplCode == employee.EmplCode);

            if (employeeDetail is null)
            {
                // Employee detail not found, return appropriate message
                return new RequestResultDTO("EMPLOYEE DETAIL NOT FOUND", null);
            }

            if (employeeDetail.BirthDate is null || employeeDetail.BirthDate != birthDateString)
            {
                // Birthdate validation failed, return appropriate message
                return new RequestResultDTO("BIRTHDATE VALIDATION FAILED", null);
            }

            // Create user cred record
            // Name for log entry max length 10
            string logName = employee.FirstName.ToUpper();
            if (logName.Length > 10)
            {
                logName = logName.Substring(0, 10);
            }

            var userCred = new HrUserCred
            {
                EmplCode = employee.EmplCode,
                Status = 1,
                Username = username,
                PasswordHash = passwordHash,
                CreatedDate = DateTime.Now,
                CreatedUser = logName,
                ModifiedDate = DateTime.Now,
                ModifiedUser = logName
            };

            // Add user cred record to the database
            await _miasHRDbContext.AddAsync(userCred);
            await _miasHRDbContext.SaveChangesAsync();

            // Prepare data for the success result
            var data = new Dictionary<string, dynamic>
            {
                { "username", username },
                { "passwordHash", passwordHash },
                { "birthDate", birthDate }
            };

            // Return success result with additional information
            return new RequestResultDTO("SUCCESS", data);
        }

        /// <summary>
        /// Updates the password for a user based on the provided employee code and new password.
        /// </summary>
        /// <param name="emplCode">The employee code identifying the user.</param>
        /// <param name="newPassword">The new password to set for the user.</param>
        /// <returns>
        /// A RequestResultDTO representing the result of the password update.
        /// The RequestResultDTO contains a status indicating success or failure, along with additional information.
        /// </returns>
        public async Task<RequestResultDTO> UpdateUserPassword(string emplCode, string newPassword)
        {
            // Default result with "FAILED" status
            RequestResultDTO requestResultDTO = new RequestResultDTO("FAILED", null);

            // Retrieve the user with the provided employee code
            var updatePassword = await _miasHRDbContext.HrUserCreds
                .FirstOrDefaultAsync(r => r.EmplCode == emplCode);

            if (updatePassword != null)
            {
                // Update the password hash and modified date
                updatePassword.PasswordHash = newPassword;
                updatePassword.ModifiedDate = DateTime.Now;

                // TODO: Log the user who modified the password

                // Save changes to the database
                _miasHRDbContext.SaveChanges();

                // Set result status to "SUCCESS" and include additional information
                requestResultDTO.status = "SUCCESS";
                requestResultDTO.data = new Dictionary<string, dynamic>();
                requestResultDTO.data.Add("emplCode", emplCode);
                requestResultDTO.data.Add("newPass", newPassword);
            }
            else
            {
                // User with the provided employee code not found, throw an exception
                throw new Exception($"Update Password Failed with ID {emplCode}");
            }

            return requestResultDTO;
        }

        /// <summary>
        /// Checks the existence of a user based on the provided username and birthdate.
        /// </summary>
        /// <param name="username">The username to check for existence.</param>
        /// <param name="birthDate">The birthdate to check for existence in the employee details.</param>
        /// <returns>
        /// An UpdateMessageDTO representing the result of the user existence check.
        /// The UpdateMessageDTO contains a message indicating success or failure, along with additional information.
        /// </returns>
        public async Task<UpdateMessageDTO> GetUserExist(string username, DateOnly birthDate)
        {
            // Check if the user credentials exist
            var existingUserCred = await _miasHRDbContext.HrUserCreds
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Username == username && x.Status != 3);

            if (existingUserCred is null)
            {
                // User credentials not found, return appropriate message
                return new UpdateMessageDTO { msg = "USER DOESN'T EXIST. PLEASE REGISTER" };
            }
            else
            {
                // Check whether there is any employee detail with the given birthdate
                var birthDateCheck = await _miasHRDbContext.HrEmployeeDetails
                    .AsNoTrackingWithIdentityResolution()
                    .FirstOrDefaultAsync(b => b.BirthDate == birthDate.ToString("yyyyMMdd") && b.Status != 3);

                if (birthDateCheck is null)
                {
                    // Employee birthdate not found, return appropriate message
                    return new UpdateMessageDTO { msg = "EMPLOYEE BIRTHDATE NOT FOUND" };
                }

                // User, email, and birthdate all exist, return success message with additional information
                return new UpdateMessageDTO { msg = "SUCCESS", com_email = username, empl_code = birthDateCheck.EmplCode };
            }
        }


    }

}

using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Telerik.SvgIcons;

namespace MiasHR.Api.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;
        private static readonly Encoding SafeUTF8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public AuthRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        public async Task<HrEmployee>? Login(string username, string passwordHash)
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
            logEntry.AcceptYn = "Y";
            await _miasHRDbContext.AddAsync(logEntry);
            await _miasHRDbContext.SaveChangesAsync();

            // get user employee info from database
            var employee = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(x => x.EmplCode == userCred.EmplCode);

            return employee;
        }

        public async Task<RequestResultDTO> Register(string username, string passwordHash, DateOnly birthDate)
        {
            // check if user already exists
            var existingUserCred = await _miasHRDbContext.HrUserCreds
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Username == username
                                 && x.Status != 3);

            if (existingUserCred is not null)
            {
                return new RequestResultDTO("USER EXISTS", null);
            }

            // verify username is a valid Mias email
            var employee = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.ComEmail == username);

            if (employee is null)
            {
                return new RequestResultDTO("EMPLOYEE EMAIL NOT FOUND", null);
            }

            // verify birthdate matches employee record
            var birthDateString = birthDate.ToString("yyyyMMdd");

            var employeeDetail = await _miasHRDbContext.HrEmployeeDetails
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.EmplCode == employee.EmplCode);

            if (employeeDetail is null)
            {
                return new RequestResultDTO("EMPLOYEE DETAIL NOT FOUND", null);
            }

            if (employeeDetail.BirthDate is null || employeeDetail.BirthDate != birthDateString)
            {
                return new RequestResultDTO("BIRTHDATE VALIDATION FAILED", null);
            }

            // create user cred record
            // name for log entry max length 10
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

            // add user cred record to database
            await _miasHRDbContext.AddAsync(userCred);
            await _miasHRDbContext.SaveChangesAsync();

            var data = new Dictionary<string, dynamic>
            {
                { "username", username },
                { "passwordHash", passwordHash },
                { "birthDate", birthDate }
            };

            return new RequestResultDTO("SUCCESS", data);
        }

        public Task<RequestResultDTO> UpdateUserPassword(string username, string oldPasswordHash, string newPasswordHash)
        {
            throw new NotImplementedException();

        }

        public async Task<UpdateMessageDTO> GetUserExist(string username, DateOnly birthDate)
        {

            var existingUserCred = await _miasHRDbContext.HrUserCreds
          .AsNoTrackingWithIdentityResolution()
          .FirstOrDefaultAsync(x => x.Username == username
                           && x.Status != 3);

            if (existingUserCred is null)
            {
                return new UpdateMessageDTO { msg = "USER DOESN'T EXIST. PLEASE REGISTER", com_email = username };
            }
            else
            {
                //Check whether there is any employee history with given email and birthdate 
                var emailCheck = await _miasHRDbContext.HrEmployees
                    .AsNoTrackingWithIdentityResolution()
                    .FirstAsync(e => e.ComEmail == username && e.Status != 3);
                if (emailCheck is null)
                {
                    return new UpdateMessageDTO { msg = "EMPLOYEE EMAIL NOT FOUND", com_email = username };
                }

                var birthDateCheck = await _miasHRDbContext.HrEmployeeDetails
                    .AsNoTrackingWithIdentityResolution()
                    .FirstAsync(b => b.BirthDate == birthDate.ToString("yyyyMMdd") && b.Status != 3);
                if (birthDateCheck is null)
                {
                    return new UpdateMessageDTO { msg = "EMPLOYEE BIRTHDATE NOT FOUND", com_email = username };
                }
                return new UpdateMessageDTO { msg = "SUCCESS", com_email = username };
            }
        }


    }

}

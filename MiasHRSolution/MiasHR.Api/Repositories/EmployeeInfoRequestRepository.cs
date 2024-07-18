using Dapper;
using Microsoft.EntityFrameworkCore;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MiasHR.Api.Repositories
{
    public class EmployeeInfoRequestRepository : IEmployeeInfoRequestRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public EmployeeInfoRequestRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves basic employee information by employee code.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <returns>The simple information about employee.</returns>
        public async Task<HrEmployee> GetBasicEmployeeInfo(string emplCode)
        {
            return await _miasHRDbContext.HrEmployees
                .Where(r => r.EmplCode == emplCode
                        && r.Status != 3)
                .FirstAsync();
        }

        /// <summary>
        /// Retrieves information for all active employees in the "MIAS" organization.
        /// </summary>
        /// <returns> Company Contact information of all Active Employee</returns>
        public async Task<IReadOnlyList<HrEmployee>> GetAllEmployeeInfo()
        {
            return await _miasHRDbContext.HrEmployees
                .Where(r => r.Status == 1
                        && r.OrgCode == "MIAS"
                        && r.ActiveYn == "Y")
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves detailed employee information by employee code.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <returns>Personal Information about the employee</returns>
        public async Task<HrEmployeeDetail> GetDetailEmployeeInfo(string emplCode)
        {
            return await _miasHRDbContext.HrEmployeeDetails
                .Where(r => r.EmplCode == emplCode)
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync();
        }

        /// <summary>
        /// Retrieves employee transfer history by employee code.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <returns>Transfer History about the employee</returns>
        public async Task<IReadOnlyList<TransferHistoryDTO>> GetEmployeeTransferHistory(string emplCode)
        {

            var parameters = new
            {
                pOrgCode = "WEB",
                pCategory = "HISTORY",
                pEmplCode = emplCode
            };

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                var result = await connection.QueryAsync<TransferHistoryDTO>(
                    "sp_HR_PersonalInfo_Other",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList().AsReadOnly();
            }

        }

        /// <summary>
        /// Retrieves employee award and disciplinary history by employee code.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <returns>Award And Disciplinary History about the employee</returns>
        public async Task<IReadOnlyList<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string emplCode)
        {
            var parameters = new
            {
                pOrgCode = "WEB",
                pCategory = "RP",
                pEmplCode = emplCode
            };

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                var result = await connection.QueryAsync<ADHistoryDTO>(
                    "sp_HR_PersonalInfo_Other",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList().AsReadOnly();
            }

        }

        /// <summary>
        /// Retrieves employee award and disciplinary history by employee code.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="newPass">The employee code.</param>
        /// <returns>Award And Disciplinary History about the employee</returns>
        public async Task<RequestResultDTO> UpdateUserPassword(string emplCode, string newPass)
        {
            //default
            RequestResultDTO requestResultDTO = new RequestResultDTO("FAILURE",null);

            var updatePassword = await _miasHRDbContext.HrWebUsers
                .FirstAsync(r => r.EmplCode == emplCode);
            if (updatePassword != null)
            {
                updatePassword.Pw = newPass;
                updatePassword.ModifiedDate = DateTime.Now;
                //TODO: modified user
                _miasHRDbContext.SaveChanges();
                requestResultDTO.status = "SUCCESS";
                requestResultDTO.data = new Dictionary<string, dynamic>();
                requestResultDTO.data.Add("emplCode", emplCode);
                requestResultDTO.data.Add("newPass", newPass);

            }
            else
            {
                throw new Exception($"Update Password Failed with ID {emplCode}");
            }

            return requestResultDTO;

        }

        /// <summary>
        /// Retrieves employee list for given manager emplCode
        /// jmn option will be used to get all members from the department JMN manages (Requested 7/12/24)
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="jmnOption">The flag for jmn employee list option</param>
        /// <returns>Get List of Employees for manager</returns>
        public async Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string emplCode, string jmnOption)
        {
            var parameters = new
            {
                pEmplCode = emplCode,
                pJmnOption = jmnOption
            };

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                var result = await connection.QueryAsync<ManagerEmployeeListDTO>(
                    "sp_HR_ManagerEmployeeList",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList().AsReadOnly();
            }


        }
    }
}

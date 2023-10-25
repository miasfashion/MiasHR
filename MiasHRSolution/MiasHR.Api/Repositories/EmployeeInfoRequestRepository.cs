using Dapper;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

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
        /// <param name="empl_code">The employee code.</param>
        /// <returns>The simple information about employee.</returns>
        public async Task<HrEmployee> GetBasicEmployeeInfo(string empl_code)
        {
            return await _miasHRDbContext.HrEmployees
                .Where(r => r.EmplCode == empl_code
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
        /// <param name="empl_code">The employee code.</param>
        /// <returns>Personal Information about the employee</returns>
        public async Task<HrEmployeeDetail> GetDetailEmployeeInfo(string empl_code)
        {
            return await _miasHRDbContext.HrEmployeeDetails
                .Where(r => r.EmplCode == empl_code)
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync();
        }

        /// <summary>
        /// Retrieves employee transfer history by employee code.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <returns>Transfer History about the employee</returns>
        public async Task<IReadOnlyList<TransferHistoryDTO>> GetEmployeeTransferHistory(string empl_code)
        {

            var parameters = new
            {
                pOrgCode = "WEB",
                pCategory = "HISTORY",
                pEmplCode = empl_code
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
        /// <param name="empl_code">The employee code.</param>
        /// <returns>Award And Disciplinary History about the employee</returns>
        public async Task<IReadOnlyList<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string empl_code)
        {
            var parameters = new
            {
                pOrgCode = "WEB",
                pCategory = "RP",
                pEmplCode = empl_code
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
        /// <param name="empl_code">The employee code.</param>
        /// <param name="newPass">The employee code.</param>
        /// <returns>Award And Disciplinary History about the employee</returns>
        public int UpdateUserPassword(string empl_code, string newPass)
        {

            var updatePassword = _miasHRDbContext.HrWebUsers
                .First(r => r.EmplCode == empl_code);
            if (updatePassword != null)
            {
                updatePassword.Pw = newPass;
                updatePassword.ModifiedDate = DateTime.Now;
                //TODO: modified user
                return _miasHRDbContext.SaveChanges();
            }
            else
            {
                throw new Exception($"Update Password Failed with ID {empl_code}");
            }

        }

        /// <summary>
        /// Retrieves employee list for given manager empl_code
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <returns>Get List of Employees for manager</returns>
        public async Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string empl_code)
        {
            var parameters = new
            {
                pEmplCode = empl_code
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

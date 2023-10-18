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

        // Retrieves basic employee information by employee code.
        public async Task<HrEmployee> GetBasicEmployeeInfo(string empl_code)
        {
            return await _miasHRDbContext.HrEmployees
                .Where(r => r.EmplCode == empl_code
                        && r.Status != 3)
                .FirstAsync();
        }

        // Retrieves information for all active employees in the "MIAS" organization.
        public async Task<IReadOnlyList<HrEmployee>> GetAllEmployeeInfo()
        {
            return await _miasHRDbContext.HrEmployees
                .Where(r => r.Status == 1
                        && r.OrgCode == "MIAS"
                        && r.ActiveYn == "Y")
                .ToListAsync();
        }

        // Retrieves detailed employee information by employee code.
        public async Task<HrEmployeeDetail> GetDetailEmployeeInfo(string empl_code)
        {
            return await _miasHRDbContext.HrEmployeeDetails
                .Where(r => r.EmplCode == empl_code)
                .FirstAsync();
        }

        // Retrieves employee transfer history by employee code.
        public async Task<IEnumerable<TransferHistoryDTO>> GetEmployeeTransferHistory(string empl_code)
        {
            try
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

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                // Log the exception or handle it appropriately.
                // You can also rethrow it if needed.
                // Example: throw ex;
            }
        }

        // Retrieves employee award and disciplinary history by employee code.
        public async Task<IEnumerable<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string empl_code)
        {
            try
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

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public async Task<int> UpdateUserPassword(string empl_code, string newPass)
        {
            try
            {
                var parameters = new
                {
                    empl = empl_code,
                    pw = newPass
                };
                var sql = @"UPDATE HR_WEB_USER SET pw = @pw, modified_date = GETDATE() WHERE empl_code = @empl ";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    await connection.OpenAsync();

                    var result = await connection.ExecuteAsync(sql, parameters);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


    }
}

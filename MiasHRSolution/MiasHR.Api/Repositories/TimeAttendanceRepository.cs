using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MiasHR.Api.Repositories
{
    public class TimeAttendanceRepository : ITimeAttendanceRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public TimeAttendanceRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves the time & attendance list for a given employee within a specified date range.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="dateFrom">The start date in yyyyMMdd format.</param>
        /// <param name="dateTo">The end date in yyyyMMdd format.</param>
        /// <returns>The time list for the given employee.</returns>
        public async Task<EmployeeTimeListDTO> GetEmployeeTimeList(string emplCode, string dateFrom, string dateTo)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pStartDt = dateFrom,
                pEndDt = dateTo,
                pEmplCode = emplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<EmployeeTimeListDTO>(
                    "sp_HR_EmployeeTimeList",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }

        /// <summary>
        /// Retrieves the time & attendance history for a given employee within a specified date range.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="dateFrom">The start date in yyyyMMdd format.</param>
        /// <param name="dateTo">The end date in yyyyMMdd format.</param>
        /// <returns>The time history for the given employee.</returns>
        public async Task<IReadOnlyList<EmployeeTimeHistoryDTO>> GetHrEmployeeTimeHistory(string emplCode, string dateFrom, string dateTo)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pStartDt = dateFrom,
                pEndDt = dateTo,
                pEmplCode = emplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<EmployeeTimeHistoryDTO>(
                    "sp_HR_EmployeeTimeHistory",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }
    }
}

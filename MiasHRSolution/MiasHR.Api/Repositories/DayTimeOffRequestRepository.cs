using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Data;

namespace MiasHR.Api.Repositories
{
    public class DayTimeOffRequestRepository : IDayTimeOffRequestRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public DayTimeOffRequestRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves a list of all day time off requests for a given employee.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <returns>A list of day time off requests.</returns>
        public async Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string empl_code)
        {
            var results = await _miasHRDbContext.HrWebRequests
                .Where(r => r.EmplCode == empl_code
                            && r.ReqType != "CHANGE"
                            && r.Status != 3)
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
            return results;
        }

        /// <summary>
        /// Creates a new day time off request.
        /// </summary>
        /// <param name="entity">The day time off request entity.</param>
        /// <returns>The number of state entries written to the database.</returns>
        public async Task<int> CreateDayTimeOffRequest(HrWebRequest entity)
        {
            await _miasHRDbContext.AddAsync<HrWebRequest>(entity);
            var result = await _miasHRDbContext
                .SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Retrieves a day time off request by its ID.
        /// </summary>
        /// <param name="Id">The ID of the day time off request.</param>
        /// <returns>The day time off request.</returns>
        public async Task<HrWebRequest>? GetDayTimeOffRequest(int Id)
        {
            return await _miasHRDbContext.HrWebRequests
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(r => r.Seq == Id);
        }

        public Task<int> UpdateDayTimeOffRequest(int Id, HrWebRequest entity)
        {
            var dayTimeOffRequest = _miasHRDbContext.HrWebRequests
                .First(r => r.Seq == Id);
            if (dayTimeOffRequest != null)
            {
                dayTimeOffRequest.Status = entity.Status;
                return _miasHRDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"DayTimeOffRequest with ID {Id} not found.");
            }
        }

        /// <summary>
        /// Deletes a day time off request by its ID.
        /// </summary>
        /// <param name="Id">The ID of the day time off request.</param>
        /// <returns>The number of state entries written to the database.</returns>
        public async Task<int> DeleteDayTimeOffRequest(int Id)
        {
            var dayTimeOffRequest =  await _miasHRDbContext.HrWebRequests
                .FirstAsync(r => r.Seq == Id);
            if (dayTimeOffRequest != null)
            {
                dayTimeOffRequest.Status = 3;
                return await _miasHRDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"DayTimeOffRequest with ID {Id} not found.");
            }
        }

        /// <summary>
        /// Retrieves a list of all day time off requests for a given employee.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off history is requested.</param>
        /// <returns>A read-only list of day time off requests.</returns>
        public async Task<IReadOnlyList<HrEmployeeDayTimeOffHistory>> GetEmployeeDayTimeOffHistoryList(string empl_code, string year)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pEmplCode = empl_code,
                pYYYY = year,
                pType = "DAYS-WEB"
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HrEmployeeDayTimeOffHistory>(
                    "sp_HR_EmployeeVacation",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }

        /// <summary>
        /// Retrieves the remaining day time off for a given employee for a specific year.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off is requested.</param>
        /// <returns>The remaining day time off for the employee.</returns>
        public async Task<HrEmployeeDayTimeOffRemaining> GetDayTimeOffRemainingByEmployee(string empl_code, string year)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pEmplCode = empl_code,
                pYYYY = year,
                pType = "DAYSINFO"
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<HrEmployeeDayTimeOffRemaining>(
                    "sp_HR_EmployeeVacation",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }

        /// <summary>
        /// Retrieves a list of day time off requests for a given employee for a specific year.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off requests are requested.</param>
        /// <returns>A read-only list of day time off requests.</returns>
        public async Task<IReadOnlyList<HrDayTimeOffRequestResult>> GetDayTimeOffRequestResultList(string empl_code, string year)
        {
            var param = new
            {
                pEmplCode = empl_code,
                pYYYY = year,
                pType = "PTO",
                pSeq = 0
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HrDayTimeOffRequestResult>(
                    "sp_HR_WebRequestList",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }

        /// <summary>
        /// Retrieves a list of pending day time off requests for a given manager.
        /// </summary>
        /// <param name="manager_empl_code">The manager's employee code.</param>
        /// <returns>A read-only list of pending day time off requests.</returns>
        public async Task<IReadOnlyList<HrPendingDayTimeOffApproval>> GetPendingDayTimeOffRequestList(string manager_empl_code)
        {
            List<HrPendingDayTimeOffApproval> result = new List<HrPendingDayTimeOffApproval>();
            var param = new
            {
                pEmplCode = manager_empl_code,
                pType = "PTO",
                pIP = "",
                pUser = manager_empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var pto = await connection.QueryAsync<HrPendingDayTimeOffApproval>(
                    "sp_HR_WebApprovalWaiting",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                result.AddRange(pto.ToList());
            }
            param = new
            {
                pEmplCode = manager_empl_code,
                pType = "VACATION",
                pIP = "",
                pUser = manager_empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var vacation = await connection.QueryAsync<HrPendingDayTimeOffApproval>(
                    "sp_HR_WebApprovalWaiting",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                result.AddRange(vacation.ToList());
            }
            param = new
            {
                pEmplCode = manager_empl_code,
                pType = "SICK DAY",
                pIP = "",
                pUser = manager_empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var sickDay = await connection.QueryAsync<HrPendingDayTimeOffApproval>(
                    "sp_HR_WebApprovalWaiting",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                result.AddRange(sickDay.ToList());
            }
            return result.AsReadOnly();
        }

        /// <summary>
        /// Retrieves a list of day time off approval histories for a given manager.
        /// </summary>
        /// <param name="manager_empl_code">The manager's employee code.</param>
        /// <returns>A read-only list of day time off approval histories.</returns>
        public async Task<IReadOnlyList<HrDayTimeOffApprovalHistory>> GetHrDayTimeOffApprovalHistories(string manager_empl_code)
        {
            var param = new
            {
                pEmplCode = "",
                pYYYY = "",
                pType = "PTO",
                pSeq = 0,
                pApprover = manager_empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HrDayTimeOffApprovalHistory>(
                    "sp_HR_WebRequestList",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }
    }
}

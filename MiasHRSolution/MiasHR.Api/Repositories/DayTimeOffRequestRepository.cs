using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Text.RegularExpressions;

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
        /// <param name="emplCode">The employee code.</param>
        /// <returns>A list of day time off requests.</returns>
        public async Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string emplCode)
        {
            var results = await _miasHRDbContext.HrWebRequests
                .Where(r => r.EmplCode == emplCode
                            && r.ReqType != "CHANGE"
                            && r.Status != 3)
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
            return results;
        }

        public async Task<RequestResultDTO> CreateDayTimeOffRequest(string emplCode,
                                                                    string type,
                                                                    string subType,
                                                                    DateOnly fromDate,
                                                                    DateOnly toDate,
                                                                    string title,
                                                                    string content,
                                                                    string ip,
                                                                    string user,
                                                                    int hours,
                                                                    decimal daysCnt,
                                                                    TimeOnly time,
                                                                    string sickDayYn)
        {
            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");
            string timeString = time.ToString("hh:mm:ss");
            var param = new
            {
                pEmplCode = emplCode,
                pType = type,
                pSubType = subType,
                pFrom = fromDateString,
                pTo = toDateString,
                pTitle = "",
                pContent = content,
                pIP = ip,
                pUser = user,
                pNewType = "NEW",
                pDaysCnt = daysCnt,
                pTime = timeString,
                @pSickDayYn = sickDayYn
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<UpdateMessageDTO>(
                    "sp_HR_WebRequest",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                // request will return approver email as msg if successful
                var email = result.com_email;
                if (!string.IsNullOrWhiteSpace(email))
                    try
                    {
                        if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                            return new RequestResultDTO("SUCCESS", new Dictionary<string, dynamic> { { "email", email } });
                        else
                            return new RequestResultDTO("FAILURE", null);
                    }
                    catch (RegexMatchTimeoutException)
                    {
                        return new RequestResultDTO("FAILURE", null);
                    }
                else
                    return new RequestResultDTO("FAILURE", null);
            }
        }

        /// <summary>
        /// Retrieves a day time off request by its ID.
        /// </summary>
        /// <param name="id">The ID of the day time off request.</param>
        /// <returns>The day time off request.</returns>
        public async Task<HrWebRequest>? GetDayTimeOffRequest(int id)
        {
            return await _miasHRDbContext.HrWebRequests
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(r => r.Seq == id);
        }

        public Task<int> UpdateDayTimeOffRequest(int id, HrWebRequest entity)
        {
            var dayTimeOffRequest = _miasHRDbContext.HrWebRequests
                .First(r => r.Seq == id);
            if (dayTimeOffRequest != null)
            {
                dayTimeOffRequest.Status = entity.Status;
                return _miasHRDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"DayTimeOffRequest with ID {id} not found.");
            }
        }

        /// <summary>
        /// Deletes a day time off request by its ID.
        /// </summary>
        /// <param name="id">The ID of the day time off request.</param>
        /// <returns>The number of state entries written to the database.</returns>
        public async Task<RequestResultDTO> DeleteDayTimeOffRequest(int id)
        {
            var dayTimeOffRequest =  await _miasHRDbContext.HrWebRequests
                .FirstAsync(r => r.Seq == id);
            if (dayTimeOffRequest != null)
            {
                dayTimeOffRequest.Status = 3;
                var result = await _miasHRDbContext.SaveChangesAsync();
                if (result > 0)
                    return new RequestResultDTO("SUCCESS", new Dictionary<string, dynamic> { { "id", id } });
                else
                    return new RequestResultDTO("FAILURE", null);
            }
            else
            {
                return new RequestResultDTO("FAILURE", null);
            }
        }

        /// <summary>
        /// Retrieves a list of all day time off requests for a given employee.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off history is requested.</param>
        /// <returns>A read-only list of day time off requests.</returns>
        public async Task<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>> GetEmployeeDayTimeOffHistoryList(string emplCode, string year)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pEmplCode = emplCode,
                pYYYY = year,
                pType = "DAYS-WEB"
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<EmployeeDayTimeOffHistoryDTO>(
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
        /// <param name="emplCode">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off is requested.</param>
        /// <returns>The remaining day time off for the employee.</returns>
        public async Task<EmployeeDayTimeOffRemainingDTO> GetDayTimeOffRemainingByEmployee(string emplCode, string year)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pEmplCode = emplCode,
                pYYYY = year,
                pType = "DAYSINFO"
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<EmployeeDayTimeOffRemainingDTO>(
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
        /// <param name="emplCode">The employee code.</param>
        /// <param name="year">The year for which the employee's day time off requests are requested.</param>
        /// <returns>A read-only list of day time off requests.</returns>
        public async Task<IReadOnlyList<DayTimeOffRequestResultDTO>> GetDayTimeOffRequestResultList(string emplCode, string year)
        {
            var param = new
            {
                pEmplCode = emplCode,
                pYYYY = year,
                pType = "PTO",
                pSeq = 0
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<DayTimeOffRequestResultDTO>(
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
        /// <param name="managerEmplCode">The manager's employee code.</param>
        /// <returns>A read-only list of pending day time off requests.</returns>
        public async Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>> GetPendingDayTimeOffRequestList(string managerEmplCode)
        {
            List<PendingDayTimeOffApprovalDTO> result = new List<PendingDayTimeOffApprovalDTO>();
            var param = new
            {
                pEmplCode = managerEmplCode,
                pType = "PTO",
                pIP = "",
                pUser = managerEmplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var pto = await connection.QueryAsync<PendingDayTimeOffApprovalDTO>(
                    "sp_HR_WebApprovalWaiting",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                result.AddRange(pto.ToList());
            }
            param = new
            {
                pEmplCode = managerEmplCode,
                pType = "VACATION",
                pIP = "",
                pUser = managerEmplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var vacation = await connection.QueryAsync<PendingDayTimeOffApprovalDTO>(
                    "sp_HR_WebApprovalWaiting",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                result.AddRange(vacation.ToList());
            }
            param = new
            {
                pEmplCode = managerEmplCode,
                pType = "SICK DAY",
                pIP = "",
                pUser = managerEmplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var sickDay = await connection.QueryAsync<PendingDayTimeOffApprovalDTO>(
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
        /// <param name="managerEmplCode">The manager's employee code.</param>
        /// <returns>A read-only list of day time off approval histories.</returns>
        public async Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>> GetHrDayTimeOffApprovalHistory(string managerEmplCode)
        {
            var param = new
            {
                pEmplCode = "",
                pYYYY = "",
                pType = "PTO",
                pSeq = 0,
                pApprover = managerEmplCode
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<DayTimeOffApprovalHistoryDTO>(
                    "sp_HR_WebRequestList",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }
    }
}

using AutoMapper;
using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;

namespace MiasHR.Api.Repositories
{
    public class DayTimeOffRequestRepository : IDayTimeOffRequestRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;


        public DayTimeOffRequestRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration, IMapper mapper)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
            _mapper = mapper;

        }

        /// <summary>
        /// Retrieves a list of all day time off requests for a given employee.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <returns>A list of day time off requests.</returns>
        public async Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year)
        {
            int targetYear = int.Parse(year);

            var results = await _miasHRDbContext.HrWebRequests
                .Where(r => r.EmplCode == emplCode
                            && r.ReqType != "CHANGE"
                            && r.Status != 3
                            && (Convert.ToInt32(r.PeriodTo.Substring(0, 4)) == targetYear
                            || Convert.ToInt32(r.PeriodFrom.Substring(0, 4)) == targetYear)
                            )
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
            var DTOList = _mapper.Map<List<DayTimeOffRequestDTO>>(results);

            return DTOList.AsReadOnly();
        }

        public async Task<RequestResultDTO> CreateDayTimeOffRequest(string emplCode,
                                                                    string type,
                                                                    string subType,
                                                                    DateTime fromDate,
                                                                    DateTime toDate,
                                                                    string title,
                                                                    string content,
                                                                    string user,
                                                                    int hours,
                                                                    decimal daysCnt,
                                                                    TimeSpan time,
                                                                    string sickDayYn)
        {
            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");
            string timeString = time.ToString(@"hh\:mm\:ss");
            var param = new
            {
                pEmplCode = emplCode,
                pType = type,
                pSubType = subType,
                pFrom = fromDateString,
                pTo = toDateString,
                pTitle = title,
                pContent = content,
                pUser = user,
                pNewType = "NEW",
                pDaysCnt = daysCnt,
                pHours = hours,
                pTime = timeString,
                pSickDayYn = sickDayYn
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

        public async Task<RequestResultDTO> EditDayTimeOffRequest(string emplCode,
                                                       string type,
                                                       string subType,
                                                       DateTime fromDate,
                                                       DateTime toDate,
                                                       decimal daysCnt,
                                                       string title,
                                                       string content,
                                                       string user,
                                                       int seq,
                                                       int hours,
                                                       TimeSpan time,
                                                       string sickDayYn)
        {
            string fromDateString = fromDate.ToString("yyyyMMdd");
            string toDateString = toDate.ToString("yyyyMMdd");
            string timeString = time.ToString(@"hh\:mm\:ss");
            var param = new
            {
                pEmplCode = emplCode,
                pType = type,
                pSubType = subType,
                pFrom = fromDateString,
                pTo = toDateString,
                pDaysCnt = daysCnt,
                pTitle = title,
                pContent = content,
                pUser = user,
                pSeq = seq,
                pHours = hours,
                pTime = timeString,
                pSickDayYn = sickDayYn,
                pNewType = "VALID"
            };
            //TODO:Need to implement function that sends email. Needed for new request + approval 
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<UpdateMessageDTO>(
                    "sp_HR_WebRequest_Edit",
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
        public async Task<DayTimeOffRequestDTO>? GetDayTimeOffRequest(int id)
        {
            var result = await _miasHRDbContext.HrWebRequests
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(r => r.Seq == id);
            var resultMap = _mapper.Map<DayTimeOffRequestDTO>(result);

            return resultMap;
        }

        /// <summary>
        /// Cancel a day time off request by its ID.
        /// </summary>
        /// <param name="id">The ID of the day time off request.</param>
        /// <returns>The number of state entries written to the database.</returns>
        public async Task<string> CancelDayTimeOffRequest(int id, string emplCode)
        {

            var param = new DynamicParameters();
            param.Add("@pseq", id);
            param.Add("@puser", emplCode);
            param.Add("@pStatusType", "CANCEL");
            param.Add("@pRejectReason", "");

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync(
                    "sp_HR_WebRequestStatusChange",
                    param,
                    commandType: CommandType.StoredProcedure
                );

                //Retrieve the output 
                string resultMessage = result.result_message;
                return resultMessage;
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

        public async Task<string> GetSickDaysRemaining(string emplCode)
        {
            string result = "";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                using (var command = new SqlCommand("SELECT dbo.sf_HR_GetSickDays(@year, @empl, @type)", connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@year", DateTime.Now.Year);
                    command.Parameters.AddWithValue("@empl", emplCode);
                    command.Parameters.AddWithValue("@type", "CURRDAYS");

                    await connection.OpenAsync();
                    var scalarResult = await command.ExecuteScalarAsync();
                    if (scalarResult != null && scalarResult != DBNull.Value)
                    {
                        // Convert the result to a string
                        result = scalarResult.ToString();
                    }
                }
            }
            return result;

        }

        public async Task<string> GetVacationRemaining(string emplCode)
        {
            string result = "";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                using (var command = new SqlCommand("SELECT dbo.sf_Hr_GetVacationDays(@year, @empl, @type)", connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@year", DateTime.Now.Year);
                    command.Parameters.AddWithValue("@empl", emplCode);
                    command.Parameters.AddWithValue("@type", "CURRDAYS");

                    await connection.OpenAsync();
                    var scalarResult = await command.ExecuteScalarAsync();
                    if (scalarResult != null && scalarResult != DBNull.Value)
                    {
                        // Convert the result to a string
                        result = scalarResult.ToString();
                    }
                }
            }
            return result;

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
                pYYYY = DateTime.Now.Year,
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

        public async Task<RequestStatusChangeResultDTO> ChangeRequestStatus(int id, string statusType, string managerEmplCode, string rejectReason)
        {
            if (statusType != "REJECT" && statusType != "APPROVAL")
            {
                // If statusType is neither "REJECT" nor "APPROVE", throw an exception
                throw new BadHttpRequestException("Invalid rejectReason value");
            }

            var param = new
            {
                pSeq = id,
                pStatusType = statusType,
                pUser = managerEmplCode,
                pRejectReason = rejectReason == "REJECT" ? rejectReason : string.Empty // Conditional assignment
            };

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<RequestStatusChangeResultDTO>(
                    "sp_HR_WebRequestStatusChange",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }
    }
}

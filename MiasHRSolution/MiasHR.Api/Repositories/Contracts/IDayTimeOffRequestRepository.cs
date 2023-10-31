using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
using System.Collections.Generic;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<UpdateMessageDTO> CreateDayTimeOffRequest(string emplCode,
                                                       string type,
                                                       string subType,
                                                       DateOnly fromDate,
                                                       DateOnly toDate,
                                                       string title,
                                                       string content,
                                                       string ip,
                                                       string user,
                                                       string newType,
                                                       int hours,
                                                       decimal daysCnt,
                                                       TimeOnly time,
                                                       string sickDayYn);

        Task<HrWebRequest>? GetDayTimeOffRequest(int id);

        Task<int> UpdateDayTimeOffRequest(int id,
                                          string emplCode = "",
                                          string type = "",
                                          string subType = "",
                                          DateOnly? fromDate = null,
                                          DateOnly? toDate = null,
                                          string title = "",
                                          string content = "",
                                          string ip = "",
                                          string user = "",
                                          int hours = -1,
                                          decimal daysCnt = -1,
                                          TimeOnly? time = null,
                                          string sickDayYn = "");

        Task<int> DeleteDayTimeOffRequest(int id);

        Task<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>? GetEmployeeDayTimeOffHistoryList(string emplCode, string year);

        Task<EmployeeDayTimeOffRemainingDTO>? GetDayTimeOffRemainingByEmployee(string emplCode, string year);

        Task<IReadOnlyList<DayTimeOffRequestResultDTO>>? GetDayTimeOffRequestResultList(string emplCode, string year);

        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);

        Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string emplCode);

        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);

    }
}

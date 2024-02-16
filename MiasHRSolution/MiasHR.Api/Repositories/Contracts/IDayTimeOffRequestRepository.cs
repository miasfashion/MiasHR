using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
using System.Collections.ObjectModel;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<RequestResultDTO> CreateDayTimeOffRequest(string emplCode,
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
                                                       string sickDayYn);

        Task<HrWebRequest>? GetDayTimeOffRequest(int id);

        Task<string> CancelDayTimeOffRequest(int id, string emplCode);

//      Task<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>? GetEmployeeDayTimeOffHistoryList(string emplCode, string year);

        Task<EmployeeDayTimeOffRemainingDTO>? GetDayTimeOffRemainingByEmployee(string emplCode, string year);

//      Task<IReadOnlyList<DayTimeOffRequestResultDTO>>? GetDayTimeOffRequestResultList(string emplCode, string year);

        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);

        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);

        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);

    }
}

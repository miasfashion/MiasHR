using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<RequestResultDTO> CreateDayTimeOffRequest(string emplCode,
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
                                                       string sickDayYn);
        Task<RequestResultDTO> EditDayTimeOffRequest(string emplCode,
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
                                                       string sickDayYn);
        Task<DayTimeOffRequestDTO>? GetDayTimeOffRequest(int id);
        Task<string> CancelDayTimeOffRequest(int id, string emplCode);
        Task<string> GetSickDaysRemaining(string emplCode);
        Task<string> GetVacationRemaining(string emplCode);
        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);
        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);
        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);
        Task<RequestStatusChangeResultDTO> ChangeRequestStatus(int id, string statusType, string managerEmplCode, string rejectReason);
        Task<EmployeeDayTimeOffRemainingDTO> GetDayTimeOffRemainingByEmployee(string emplCode, int year);
    }
}

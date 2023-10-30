using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
using System.Collections.Generic;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<int> CreateDayTimeOffRequest(HrWebRequest entity);

        Task<HrWebRequest>? GetDayTimeOffRequest(int id);

        Task<int> UpdateDayTimeOffRequest(int id, HrWebRequest entity);

        Task<int> DeleteDayTimeOffRequest(int id);

        Task<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>? GetEmployeeDayTimeOffHistoryList(string emplCode, string year);

        Task<EmployeeDayTimeOffRemainingDTO>? GetDayTimeOffRemainingByEmployee(string emplCode, string year);

        Task<IReadOnlyList<DayTimeOffRequestResultDTO>>? GetDayTimeOffRequestResultList(string emplCode, string year);

        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);

        Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string emplCode);

        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);

    }
}

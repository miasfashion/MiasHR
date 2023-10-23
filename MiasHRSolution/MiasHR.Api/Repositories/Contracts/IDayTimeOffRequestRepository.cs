using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
using System.Collections.Generic;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<int> CreateDayTimeOffRequest(HrWebRequest entity);

        Task<HrWebRequest>? GetDayTimeOffRequest(int Id);

        Task<int> UpdateDayTimeOffRequest(int Id, HrWebRequest entity);

        Task<int> DeleteDayTimeOffRequest(int Id);

        Task<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>? GetEmployeeDayTimeOffHistoryList(string empl_code, string year);

        Task<EmployeeDayTimeOffRemainingDTO>? GetDayTimeOffRemainingByEmployee(string empl_code, string year);

        Task<IReadOnlyList<DayTimeOffRequestResultDTO>>? GetDayTimeOffRequestResultList(string empl_code, string year);

        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string manager_empl_code);

        Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string empl_code);

        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistories(string manager_empl_code);

    }
}

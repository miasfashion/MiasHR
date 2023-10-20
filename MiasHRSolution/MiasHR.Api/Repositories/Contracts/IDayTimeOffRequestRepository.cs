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

        Task<IReadOnlyList<HrEmployeeDayTimeOffHistory>>? GetEmployeeDayTimeOffHistoryList(string empl_code, string year);

        Task<HrEmployeeDayTimeOffRemaining>? GetDayTimeOffRemainingByEmployee(string empl_code, string year);

        Task<IReadOnlyList<HrDayTimeOffRequestResult>>? GetDayTimeOffRequestResultList(string empl_code, string year);

        Task<IReadOnlyList<HrPendingDayTimeOffApproval>>? GetPendingDayTimeOffRequestList(string manager_empl_code);

        Task<IReadOnlyList<HrWebRequest>> GetAllEmployeeDayTimeOffRequestList(string empl_code);

        Task<IReadOnlyList<HrDayTimeOffApprovalHistory>>? GetHrDayTimeOffApprovalHistories(string manager_empl_code);

    }
}

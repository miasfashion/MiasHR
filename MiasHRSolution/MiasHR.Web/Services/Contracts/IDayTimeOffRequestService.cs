using Azure.Core;
using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IDayTimeOffRequestService
    {

        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);
        Task<DayTimeOffRequestDTO> GetDayTimeOffRequest(int id);
        Task<HttpResponseMessage> CreateDayTimeOffRequest(CreateRequestDTO request);
        Task<HttpResponseMessage> EditDayTimeOffRequest(EditRequestDTO request);
        Task<HttpResponseMessage> CancelDayTimeOffRequest(int id, string emplCode);
        Task<string> GetSickDaysRemaining(string emplCode);
        Task<string> GetVacationRemaining(string emplCode);
        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);
        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);
        Task<RequestStatusChangeResultDTO> ChangeRequestStatus(RequestStatusChangeDTO request);
    }
}

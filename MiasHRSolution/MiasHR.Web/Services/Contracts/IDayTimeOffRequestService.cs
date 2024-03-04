using Azure.Core;
using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IDayTimeOffRequestService
    {
        Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode);
        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);
        Task<RequestStatusChangeResultDTO> ChangeRequestStatus(RequestStatusChangeDTO request);
    }
}

using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IDayTimeOffRequestService
    {
        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);
        Task<HttpResponseMessage> GetDayTimeOffRequest(int id);
        Task<HttpResponseMessage> CreateDayTimeOffRequest(CreateRequestDTO request);
        
        Task<HttpResponseMessage> CancelDayTimeOffRequest(int id, string emplCode);
        Task<string> GetSickDaysRemaining(string emplCode);
        Task<string> GetVacationRemaining(string emplCode);

        /* Don't need
        Task<HttpResponseMessage> GetEmployeeDayTimeOffHistoryList(string emplCode, string year);
        Task<HttpResponseMessage> GetDayTimeOffRequestResultList(string emplCode, string year);
        */

        //For Manager
        //Task<HttpResponseMessage> GetPendingDayTimeOffRequestList(string managerEmplCode);
        //Task<HttpResponseMessage> GetHrDayTimeOffApprovalHistory(string managerEmplCode);
    }
}

using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IDayTimeOffRequestService
    {
        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);
        Task<HttpResponseMessage> GetDayTimeOffRequest(int id);
        /*Task<HttpResponseMessage> CreateDayTimeOffReq(string emplCode,string type,string subType,
                        DateOnly fromDate,DateOnly toDate,string title,string content,string ip,
                        string user,int hours,decimal daysCnt,TimeOnly time,string sickDayYn);
        */
        Task<HttpResponseMessage> CancelDayTimeOffRequest(int id, string emplCode);
        //Task<HttpResponseMessage> GetDayTimeOffRemainingByEmployee(string emplCode, string year);
        
        /* Don't need
        Task<HttpResponseMessage> GetEmployeeDayTimeOffHistoryList(string emplCode, string year);
        Task<HttpResponseMessage> GetDayTimeOffRequestResultList(string emplCode, string year);
        */

        //For Manager
        //Task<HttpResponseMessage> GetPendingDayTimeOffRequestList(string managerEmplCode);
        //Task<HttpResponseMessage> GetHrDayTimeOffApprovalHistory(string managerEmplCode);
    }
}

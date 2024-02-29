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
                                                       DateTime fromDate,
                                                       DateTime toDate,
                                                       string title,
                                                       string content,
                                                       string user,
                                                       int hours,
                                                       decimal daysCnt,
                                                       TimeSpan time,
                                                       string sickDayYn);

        Task<HrWebRequest>? GetDayTimeOffRequest(int id);

        Task<string> CancelDayTimeOffRequest(int id, string emplCode);

        //      Task<EmployeeDayTimeOffRemainingDTO>? 

        Task<string> GetSickDaysRemaining(string emplCode);
        Task<string> GetVacationRemaining(string emplCode);

        Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year);

        Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode);

    }
}

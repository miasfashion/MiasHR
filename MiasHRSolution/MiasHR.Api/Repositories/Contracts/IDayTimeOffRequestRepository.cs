using MiasHR.Api.Entities;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IDayTimeOffRequestRepository
    {
        Task<IEnumerable<HrWebRequest>> GetAllEmployeeDayTimeOffRequests(string empl_code);
        Task<IQueryable<(string,int)>> GetVacationDaysByEmplCode(string empl_code);
        Task<>
    }
}

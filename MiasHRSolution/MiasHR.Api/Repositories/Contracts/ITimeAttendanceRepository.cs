using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface ITimeAttendanceRepository
    {
        Task<HrEmployeeTimeList> GetEmployeeTimeList(string empl_code, string dateFrom, string dateTo);

        Task<IReadOnlyList<HrEmployeeTimeHistory>> GetHrEmployeeTimeHistory(string empl_code, string dateFrom, string dateTo);
    }
}

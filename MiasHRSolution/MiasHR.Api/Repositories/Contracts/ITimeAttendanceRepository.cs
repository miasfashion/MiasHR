using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface ITimeAttendanceRepository
    {
        Task<EmployeeTimeListDTO> GetEmployeeTimeList(string empl_code, string dateFrom, string dateTo);

        Task<IReadOnlyList<EmployeeTimeHistoryDTO>> GetHrEmployeeTimeHistory(string empl_code, string dateFrom, string dateTo);
    }
}

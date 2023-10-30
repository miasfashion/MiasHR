using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface ITimeAttendanceRepository
    {
        Task<EmployeeTimeListDTO> GetEmployeeTimeList(string emplCode, string dateFrom, string dateTo);

        Task<IReadOnlyList<EmployeeTimeHistoryDTO>> GetHrEmployeeTimeHistory(string emplCode, string dateFrom, string dateTo);
    }
}

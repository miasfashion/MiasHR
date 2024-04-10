using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface ITimeAttendanceService
    {
        Task<EmployeeTimeListDTO> GetEmployeeTimeList(TimeAttendanceDTO request);
        Task<IReadOnlyList<EmployeeTimeHistoryDTO>> GetHrEmployeeTimeHistory(TimeAttendanceDTO request);
    }
}

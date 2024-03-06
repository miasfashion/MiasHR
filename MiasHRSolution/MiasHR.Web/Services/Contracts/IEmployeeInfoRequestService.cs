using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IEmployeeInfoRequestService
    {
        Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string managerEmplCode);
    }
}

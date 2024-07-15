using MiasHR.Models.DTOs;
using MiasHR.Web.Shared;

namespace MiasHR.Web.Services.Contracts
{
    public interface IEmployeeInfoRequestService
    {
        Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string managerEmplCode);
        List<ModelData> GetDefaultVacData();
        List<ModelData> GetDefaultVacTable();
        List<ModelData> GetDefaultSickData();
        List<ModelData> GetDefaultSickTable();
    }
}

using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEmployeeInfoRequestRepository
    {
        Task<HrEmployee> GetBasicEmployeeInfo(string emplCode);
        Task<IReadOnlyList<HrEmployee>> GetAllEmployeeInfo();
        Task<HrEmployeeDetail> GetDetailEmployeeInfo(string emplCode);
        Task<IReadOnlyList<TransferHistoryDTO>> GetEmployeeTransferHistory(string emplCode);
        Task<IReadOnlyList<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string emplCode);
        Task<RequestResultDTO> UpdateUserPassword(string emplCode, string newPass);
        Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string emplCode);
    }
}

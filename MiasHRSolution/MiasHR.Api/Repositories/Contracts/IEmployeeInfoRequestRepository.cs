using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEmployeeInfoRequestRepository
    {
        Task<IEnumerable<HrEmployee>> GetBasicEmployeeInfo(string empl_code);
        Task<IEnumerable<HrEmployee>> GetAllEmployeeInfo();
        Task<IEnumerable<HrEmployeeDetail>> GetDetailEmployeeInfo(string empl_code);
        Task<IEnumerable<TransferHistoryDTO>> GetEmployeeTransferHistory(string empl_code);
        Task<IEnumerable<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string empl_code);

    }
}

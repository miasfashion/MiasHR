﻿using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEmployeeInfoRequestRepository
    {
        Task<HrEmployee> GetBasicEmployeeInfo(string empl_code);
        Task<IReadOnlyList<HrEmployee>> GetAllEmployeeInfo();
        Task<HrEmployeeDetail> GetDetailEmployeeInfo(string empl_code);
        Task<IReadOnlyList<TransferHistoryDTO>> GetEmployeeTransferHistory(string empl_code);
        Task<IReadOnlyList<ADHistoryDTO>> GetEmployeeAwardDiscHistory(string empl_code);
        int UpdateUserPassword(string empl_code, string newPass);
        Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string empl_code);
    }
}

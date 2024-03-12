using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IAuthRepository
    {
        Task<RequestResultDTO> Register(string username, string passwordHash, DateOnly birthDate);
        Task<Tuple<HrEmployee, bool>>? Login(string username, string passwordHash);
        Task<RequestResultDTO> UpdateUserPassword(string emplCode, string newPasswordHash);
        Task<UpdateMessageDTO> GetUserExist(string username, DateOnly birthDate);
        Task<UpdateMessageDTO> GetUserEmail(string emplCode);
    }
}

using MiasHR.Api.Entities;
using MiasHR.Models;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IAuthRepository
    {
        Task<RequestResultDTO> Register(string username, string passwordHash, DateOnly birthDate);

        Task<HrEmployee>? Login(string username, string passwordHash);

        Task<RequestResultDTO> UpdateUserPassword(string username, string oldPasswordHash, string newPasswordHash);
    }
}

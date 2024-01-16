using MiasHR.Models.DTOs;


namespace MiasHR.Web.Services.Contracts
{
    public interface IAuthService
    {
        Task<string> Login(UserDTO request);
        Task<RequestResultDTO> Register(UserDTO request, DateOnly birthDate);
    }
}

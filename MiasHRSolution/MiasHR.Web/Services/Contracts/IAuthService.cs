using MiasHR.Models.DTOs;


namespace MiasHR.Web.Services.Contracts
{
    public interface IAuthService
    {
        Task<HttpResponseMessage> Login(UserDTO request);
        Task<RequestResultDTO> Register(UserDTO request, DateOnly birthDate);
        Task Logout();
        Task<bool> IsLoggedIn();
    }
}

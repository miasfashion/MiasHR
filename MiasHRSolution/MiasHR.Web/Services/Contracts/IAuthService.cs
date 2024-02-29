using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IAuthService
    {
        Task<HttpResponseMessage> Login(UserDTO request);
        Task<HttpResponseMessage> Register(UserDTO request, DateOnly birthDate);
        Task<UpdateMessageDTO> GetUserExist(UserCheckDTO request);
        Task<string?> UpdateUserPassword(PassUpdateDTO request);
        Task Logout();
        Task<bool> IsLoggedIn();
        Task<string?> GetUserEmplCode();
        Task<string?> GetUserName();
    }
}

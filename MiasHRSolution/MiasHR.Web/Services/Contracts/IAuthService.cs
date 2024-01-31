using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IAuthService
    {
        Task<HttpResponseMessage> Login(UserDTO request);
        Task<HttpResponseMessage> Register(UserDTO request, DateOnly birthDate);
        Task<UpdateMessageDTO> GetUserExist(UserCheckDTO request);
        Task<HttpResponseMessage> UpdateUserPassword(string emplCode, string newPassword);
        Task Logout();
        Task<bool> IsLoggedIn();
        Task<bool> IsUserManager();
        Task<string?> GetUserEmplCode();
        Task<string?> GetUserName();
        Task<string?> TestApi(string emplCode);
    }
}

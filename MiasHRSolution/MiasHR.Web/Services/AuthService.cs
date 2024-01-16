using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;

namespace MiasHR.Web.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient httpClient;
        public AuthService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> Login(UserDTO request)
        {
            try
            {
                string token = await httpClient.GetStringAsync("/api/Auth/Login");
                return token;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<RequestResultDTO> Register(UserDTO request, DateOnly birthDate)
        {
            throw new NotImplementedException();
        }
    }
}

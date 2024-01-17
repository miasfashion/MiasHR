using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;

namespace MiasHR.Web.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<bool> IsLoggedIn()
        {
            var token = await _localStorage.GetItemAsStringAsync("authToken");
            return !string.IsNullOrEmpty(token);
            // Additional logic can be added here to validate the token's expiration.
        }

        public async Task<HttpResponseMessage> Login(UserDTO userCredentials)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/Login", userCredentials);

                if (response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();
                    await _localStorage.SetItemAsync("authToken", token);
                    await _authStateProvider.GetAuthenticationStateAsync();
                }

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public Task<RequestResultDTO> Register(UserDTO request, DateOnly birthDate)
        {
            throw new NotImplementedException();
        }
    }
}

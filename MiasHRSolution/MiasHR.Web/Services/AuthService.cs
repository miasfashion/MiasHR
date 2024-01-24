using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;
using System.Security.Claims;
using Telerik.SvgIcons;

namespace MiasHR.Web.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<bool> IsLoggedIn()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user != null)
            {
                return user.Identity.IsAuthenticated;
            }

            return false;
            // Additional logic can be added here to validate the token's expiration.
        }

        public async Task<string?> GetUserName()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
            {
                return user.FindFirst(ClaimTypes.Name)?.Value;
            }

            return null;
        }

        public async Task<string?> GetUserEmplCode()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
            {
                return user.FindFirst(ClaimTypes.SerialNumber)?.Value;
            }

            return null;
        }

        public async Task<HttpResponseMessage> Login(UserDTO userCredentials)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/Login", userCredentials);

                if (response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();
                    await _sessionStorage.SetItemAsync("authToken", token);
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
            await _sessionStorage.RemoveItemAsync("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = null;
            await _authStateProvider.GetAuthenticationStateAsync();
        }

        public async Task<HttpResponseMessage> Register(UserDTO request, DateOnly birthDate)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/Register?birthDate=" + birthDate, request);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<UpdateMessageDTO> GetUserExist(UserCheckDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/GetUserExist", request);

                //DTO will be used to collect both Status Msg and Empl Code
                if (response.IsSuccessStatusCode)
                {
                    var dto = await response.Content.ReadFromJsonAsync<UpdateMessageDTO>();
                    await _sessionStorage.SetItemAsync("empl", dto?.empl_code);
                    return dto; 
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HttpResponseMessage> UpdateUserPassword(string emplCode, string newPassword)
        {
            try
            {
                var resposne = await _httpClient.PutAsJsonAsync("api/Auth/UpdateUserPassword", new { EmplCode = emplCode, NewPassword = newPassword });
                return resposne;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string?> TestApi(string emplCode)
        {
            var year = 2023;
            try
            {
                var response = await _httpClient.GetFromJsonAsync<EmployeeDayTimeOffRemainingDTO>($"/api/DayTimeOffRequest/GetDayTimeOffRemainingByEmployee/{emplCode}/{year}");
                if (response != null)
                {
                    return "success";
                }
                return "failed";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

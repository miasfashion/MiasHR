using Azure;
using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
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
            try
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
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
        }

        public async Task<bool> IsUserManager()
        {
            try
            {
                var authState = await _authStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                if (user != null)
                {
                    return user.IsInRole("Manager");
                }

                return false;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
        }

        public async Task<string?> GetUserName()
        {
            try
            {
                var authState = await _authStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
                {
                    return user.FindFirst(ClaimTypes.Name)?.Value;
                }

                return null;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }

        }

        public async Task<string?> GetUserEmplCode()
        {
            try
            {
                var authState = await _authStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
                {
                    return user.FindFirst(ClaimTypes.SerialNumber)?.Value;
                }

                return null;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
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
            catch (HttpRequestException ex)
            {
                // HTTP Request Failed
                throw new HttpRequestException("Http Request Failed", ex);
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
        }

        public async Task Logout()
        {
            try { 
            await _sessionStorage.RemoveItemAsync("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = null;
            await _authStateProvider.GetAuthenticationStateAsync();
               
                }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
        }

        public async Task<HttpResponseMessage> Register(UserDTO request, DateOnly birthDate)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/Register?birthDate=" + birthDate, request);
                return response;
            }
            catch (HttpRequestException ex)
            {
                // HTTP Request Failed
                throw new HttpRequestException("Http Request Failed", ex);
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
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
                    if (dto.empl_code.IsNullOrEmpty())
                    {
                        return dto;
                    }
                    await _sessionStorage.SetItemAsStringAsync("empl", dto?.empl_code);
                    return dto;
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                // HTTP Request Failed
                throw new HttpRequestException("Http Request Failed", ex);
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Operation is performed.", ex);
            }
        }

        public async Task<string?> UpdateUserPassword(PassUpdateDTO request)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("api/Auth/UpdateUserPassword", request);
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            catch (HttpRequestException ex)
            {
                // HTTP Request Failed
                throw new HttpRequestException("Http Request Failed", ex);
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }
    }
}

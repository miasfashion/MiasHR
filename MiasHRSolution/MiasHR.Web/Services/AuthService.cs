using Azure.Identity;
using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Http.Json;
using System.Security.Claims;

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
        public async Task<HttpResponseMessage> GetUserExist(UserCheckDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Auth/GetUserExist", request);
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

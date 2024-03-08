using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;

namespace MiasHR.Web.Services
{
    public class EmailService : IEmailService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public EmailService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<HttpResponseMessage> SendEmail(EmailDTO emailDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/Email/SendEmail/",emailDTO);
            return response;

        }


    }
}

using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;
using System.Text.Json;

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
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/Email/SendEmail/", emailDTO);
                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("Http Reqeust Failed", ex);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Invalid Argument Passed", ex);
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }

        }


    }
}

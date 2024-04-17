using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;
using System.Text.Json;

namespace MiasHR.Web.Services
{
    public class EmployeeInfoRequestService : IEmployeeInfoRequestService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public EmployeeInfoRequestService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string managerEmplCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/EmployeeInfoRequest/GetManagerEmployeeList/{managerEmplCode}");

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<IReadOnlyList<ManagerEmployeeListDTO>>();

                return data?.ToList() ?? new List<ManagerEmployeeListDTO>();
            }
            catch (HttpRequestException ex)
            {
                // HTTP request failed
                throw new HttpRequestException("Failed to retrieve manager employee list. HTTP request failed.", ex);
            }
            catch (JsonException ex)
            {
                // JSON deserialization failed
                throw new JsonException("Failed to deserialize JSON response. JSON deserialization failed.", ex);
            }
            catch (Exception ex)
            {
                // Unexpected exception
                throw new Exception("An error occurred while retrieving manager employee list.", ex);
            }
        }
    }
}

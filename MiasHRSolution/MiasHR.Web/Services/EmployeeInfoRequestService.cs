using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;

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

                var data = await response.Content.ReadAsStringAsync();

                return new List<ManagerEmployeeListDTO> { };
            }
            catch (Exception)
			{
				throw;
			}
        }
    }
}

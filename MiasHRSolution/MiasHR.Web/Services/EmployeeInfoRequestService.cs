using MiasHR.Models.DTOs;
using MiasHR.Web.Services.Contracts;
using MiasHR.Web.Shared;
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

        // jmn option will be used to get all members from the department JMN manages (Requested 7/12/24)

        public async Task<IReadOnlyList<ManagerEmployeeListDTO>> GetManagerEmployeeList(string managerEmplCode, string jmnOption = "N")
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/EmployeeInfoRequest/GetManagerEmployeeList/{managerEmplCode}/{jmnOption}");

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

        public List<ModelData> GetDefaultVacData()
        {
            return new List<ModelData>
        {
            new ModelData { Group = " ", Category = "Used", Value = 0, Color = "#616161" },
            new ModelData { Group = " ", Category = "Available", Value = 0, Color = "#1DE9B6" },
            new ModelData { Group = " ", Category = "Available Later", Value = 0, Color = "#B0BEC5" }
        };
        }

        public List<ModelData> GetDefaultVacTable()
        {
            return new List<ModelData>
        {
            new ModelData { Group = " ", Category = "Carried Over", Value = 0 },
            new ModelData { Group = " ", Category = "Accrued", Value = 0 },
            new ModelData { Group = " ", Category = "Adjusted", Value = 0 },
            new ModelData { Group = " ", Category = "Used", Value = 0 },
            new ModelData { Group = "Total", Category = "Available", Value = 0 }
        };
        }

        public List<ModelData> GetDefaultSickData()
        {
            return new List<ModelData>
        {
            new ModelData { Category = "Used", Value = 0, Color = "#616161" },
            new ModelData { Category = "Available", Value = 0, Color = "#1DE9B6" }
        };
        }

        public List<ModelData> GetDefaultSickTable()
        {
            return new List<ModelData>
        {
            new ModelData { Category = "Sick Days", Value = 0, Color = "#616161" },
            new ModelData { Category = "Used", Value = 0, Color = "#616161" },
            new ModelData { Group = "Total", Category = "Available", Value = 0, Color = "#1DE9B6" }
        };
        }

    }
}

using MiasHR.Web.Services.Contracts;
using MiasHR.Models.DTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace MiasHR.Web.Services
{
    public class DayTimeOffRequestService : IDayTimeOffRequestService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public DayTimeOffRequestService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<HttpResponseMessage> SendHttpRequestAsync(Func<Task<HttpResponseMessage>> httpRequestFunc)
        {
            try
            {
                var response = await httpRequestFunc();
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException ex)
            {
                // HTTP Request Failed
                throw new HttpRequestException("Http Request Failed", ex);
            }
            catch (ArgumentException ex)
            {
                // Invalid Argument Passed
                throw new ArgumentException("Invalid Argument Passed", ex);
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }


        public async Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year)
        {
            var response = await SendHttpRequestAsync(() => _httpClient.GetAsync($"api/DayTimeOffRequest/GetAllEmployeeDayTimeOffRequestList/{emplCode}/{year}"));
            try
            {
                var dayOffList = await response.Content.ReadFromJsonAsync<IReadOnlyList<DayTimeOffRequestDTO>>();
                return dayOffList?.ToList() ?? new List<DayTimeOffRequestDTO>();
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }

        public async Task<HttpResponseMessage> CreateDayTimeOffRequest(CreateRequestDTO request)
        {
            return await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/CreateDayTimeOffRequest", request));
        }

        public async Task<HttpResponseMessage> EditDayTimeOffRequest(EditRequestDTO request)
        {
            return await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/EditDayTimeOffRequest", request));
        }


        public async Task<DayTimeOffRequestDTO> GetDayTimeOffRequest(int id)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.GetAsync($"api/DayTimeOffRequest/GetDayTimeOffRequest/{id}"));
            try
            {
                var offRequest = await response.Content.ReadFromJsonAsync<DayTimeOffRequestDTO>();
                return offRequest;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }
        public async Task<string> GetSickDaysRemaining(string emplCode)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/GetSickDaysRemaining", emplCode));
            try
            {
                // Deserialize the response content to a decimal
                var remainDayDecimal = await response.Content.ReadAsStringAsync();
                return remainDayDecimal;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }

        }

        public async Task<string> GetVacationRemaining(string emplCode)
        {
            var response = await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/GetVacationRemaining", emplCode));
            try
            {
                // Deserialize the response content to a decimal
                var remainDayDecimal = await response.Content.ReadAsStringAsync();
                return remainDayDecimal;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }

        public async Task<HttpResponseMessage> CancelDayTimeOffRequest(int id, string emplCode)
        {

            return await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync($"api/DayTimeOffRequest/CancelDayTimeOffRequest/{id}/{emplCode}", new { }));

        }
        public async Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.GetAsync($"/api/Manager/DayTimeOffRequest/GetHrDayTimeOffApprovalHistory/{managerEmplCode}"));
            try
            {
                var data = await response.Content.ReadFromJsonAsync<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>();
                return data;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }

        }

        public async Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.GetAsync($"/api/Manager/DayTimeOffRequest/GetPendingDayTimeOffRequestList/{managerEmplCode}"));
            try
            {
                var data = await response.Content.ReadFromJsonAsync<IReadOnlyList<PendingDayTimeOffApprovalDTO>>();
                return data;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }

        public async Task<RequestStatusChangeResultDTO> ChangeRequestStatus(RequestStatusChangeDTO request)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.PostAsJsonAsync("/api/Manager/DayTimeOffRequest/ChangeRequestStatus", request));
            try
            {
                var data = await response.Content.ReadFromJsonAsync<RequestStatusChangeResultDTO>();

                return data;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }


        }

        public async Task<EmployeeDayTimeOffRemainingDTO> GetDayTimeOffRemainingByEmployee(string emplCode, string year)
        {

            var response = await SendHttpRequestAsync(() => _httpClient.GetAsync($"/api/DayTimeOffRequest/GetDayTimeOffRemainingByEmployee/{emplCode}/{year}"));
            try
            {
                var data = await response.Content.ReadFromJsonAsync<EmployeeDayTimeOffRemainingDTO>();
                return data;
            }
            catch (JsonException ex)
            {
                throw new JsonException("JSON Deserialization Failed", ex);
            }
        }

    }
}
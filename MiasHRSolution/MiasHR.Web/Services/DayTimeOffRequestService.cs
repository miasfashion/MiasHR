using MiasHR.Web.Services.Contracts;
using MiasHR.Models.DTOs;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Azure.Core;

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
        public async Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year)
        {
            try
            {

                var response = await _httpClient.GetAsync($"api/DayTimeOffRequest/GetAllEmployeeDayTimeOffRequestList/{emplCode}/{year}");
                response.EnsureSuccessStatusCode();

                var DayOffList = await response.Content.ReadFromJsonAsync<IReadOnlyList<DayTimeOffRequestDTO>>();
                return DayOffList?.ToList() ?? new List<DayTimeOffRequestDTO>();
            }
            catch (HttpRequestException ex)
            {
                // HTTP 요청 실패를 처리합니다.
                throw;
            }
            catch (JsonException ex)
            {
                // JSON 역직렬화 실패를 처리합니다.
                throw;
            }
        }

        public async Task<HttpResponseMessage> CreateDayTimeOffRequest(CreateRequestDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/CreateDayTimeOffRequest", request);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException)
            {
                // HTTP 요청 실패를 처리합니다.
                throw;
            }
        }

        public async Task<HttpResponseMessage> EditDayTimeOffRequest(EditRequestDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/EditDayTimeOffRequest", request);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }


        public async Task<DayTimeOffRequestDTO> GetDayTimeOffRequest(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/DayTimeOffRequest/GetDayTimeOffRequest/{id}");
                response.EnsureSuccessStatusCode();

                var offRequest = await response.Content.ReadFromJsonAsync<DayTimeOffRequestDTO>();
                if (offRequest == null)
                {
                    throw new Exception("DayTimeOffRequest not found");
                }
                return offRequest;
            }
            catch (HttpRequestException)
            {
                // HTTP 요청 실패를 처리합니다.
                throw;
            }
            catch (JsonException)
            {
                // JSON 역직렬화 실패를 처리합니다.
                throw;
            }
        }
        public async Task<string> GetSickDaysRemaining(string emplCode)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/GetSickDaysRemaining", emplCode);
                // Deserialize the response content to a decimal
                var remainDayDecimal = await response.Content.ReadAsStringAsync();
                return remainDayDecimal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GetVacationRemaining(string emplCode)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/GetVacationRemaining", emplCode);
                // Deserialize the response content to a decimal
                var remainDayDecimal = await response.Content.ReadAsStringAsync();
                return remainDayDecimal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HttpResponseMessage> CancelDayTimeOffRequest(int id, string emplCode)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"api/DayTimeOffRequest/CancelDayTimeOffRequest/{id}/{emplCode}", new { });
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/Manager/DayTimeOffRequest/GetHrDayTimeOffApprovalHistory/{managerEmplCode}");

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IReadOnlyList<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string managerEmplCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/Manager/DayTimeOffRequest/GetPendingDayTimeOffRequestList/{managerEmplCode}");

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<IReadOnlyList<PendingDayTimeOffApprovalDTO>>();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RequestStatusChangeResultDTO> ChangeRequestStatus(RequestStatusChangeDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/Manager/DayTimeOffRequest/ChangeRequestStatus", request);

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<RequestStatusChangeResultDTO>();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EmployeeDayTimeOffRemainingDTO> GetDayTimeOffRemainingByEmployee(string emplCode, string year)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/DayTimeOffRequest/GetDayTimeOffRemainingByEmployee/{emplCode}/{year}");

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<EmployeeDayTimeOffRemainingDTO>();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
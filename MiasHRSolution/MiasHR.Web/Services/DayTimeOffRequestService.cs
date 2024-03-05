using MiasHR.Web.Services.Contracts;
using MiasHR.Models.DTOs;
using System.Net.Http.Json;
using System.Text;
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
    }
}

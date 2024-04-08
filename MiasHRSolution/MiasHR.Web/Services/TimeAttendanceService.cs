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
    public class TimeAttendanceService : ITimeAttendanceService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public TimeAttendanceService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;            
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }
        public async Task<EmployeeTimeListDTO> GetEmployeeTimeList(TimeAttendanceDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/TimeAttendance/GetEmployeeTimeList", request);
                var timeList = await response.Content.ReadFromJsonAsync<EmployeeTimeListDTO>();
                return timeList;
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
        public async Task<IReadOnlyList<EmployeeTimeHistoryDTO>> GetHrEmployeeTimeHistory(TimeAttendanceDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/TimeAttendance/GetHrEmployeeTimeHistory", request);
                var timeHistory = await response.Content.ReadFromJsonAsync<IReadOnlyList<EmployeeTimeHistoryDTO>>();
                return timeHistory?.ToList() ?? new List<EmployeeTimeHistoryDTO>();
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

    }
}

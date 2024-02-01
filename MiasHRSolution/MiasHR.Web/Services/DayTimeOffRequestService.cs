using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;
using MiasHR.Models.DTOs;
using System.Net;
using AutoMapper;


namespace MiasHR.Web.Services
{
    public class DayTimeOffRequestService : IDayTimeOffRequestService
    {
        private readonly HttpClient _httpClient;
        public DayTimeOffRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"api/DayTimeOffRequest/GetAllEmployeeDayTimeOffRequestList/{emplCode}", emplCode);
                if (response.IsSuccessStatusCode)
                {
                    var DayOffList = await response.Content.ReadFromJsonAsync<IReadOnlyList<DayTimeOffRequestDTO>>();
                    return DayOffList.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<HttpResponseMessage> GetDayTimeOffRequest(int id)
        {
            return null;
        }
        public async Task<HttpResponseMessage> GetDayTimeOffRemainingByEmployee(string emplCode, string year)
        {
            return null;
        }
        public async Task<HttpResponseMessage> GetEmployeeDayTimeOffHistoryList(string emplCode, string year)
        {
            return null;
        }
        public async Task<HttpResponseMessage> GetDayTimeOffRequestResultList(string emplCode, string year)
        {
            return null;
        }

    }
}

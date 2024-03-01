using MiasHR.Web.Services.Contracts;
using System.Net.Http.Json;
using MiasHR.Models.DTOs;
using System.Net;
using AutoMapper;
using Azure;


namespace MiasHR.Web.Services
{
    public class DayTimeOffRequestService : IDayTimeOffRequestService
    {
        private readonly HttpClient _httpClient;
        public DayTimeOffRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IReadOnlyList<DayTimeOffRequestDTO>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year)
        {
            try
            {

                var response = await _httpClient.GetAsync($"api/DayTimeOffRequest/GetAllEmployeeDayTimeOffRequestList/{emplCode}/{year}");
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

        public async Task<HttpResponseMessage> CreateDayTimeOffRequest(CreateRequestDTO request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/DayTimeOffRequest/CreateDayTimeOffRequest", request);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DayTimeOffRequestDTO> GetDayTimeOffRequest(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/DayTimeOffRequest/GetDayTimeOffRequest/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var offRequest = await response.Content.ReadFromJsonAsync<DayTimeOffRequestDTO>();
                    return offRequest;
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
                var response = await _httpClient.PostAsJsonAsync($"api/DayTimeOffRequest/CancelDayTimeOffRequest/{id}/{emplCode}",new { });
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

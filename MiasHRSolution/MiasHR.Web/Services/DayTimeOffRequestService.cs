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
        public async Task<HttpResponseMessage> GetDayTimeOffRequest(int id)
        {
            return null;
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

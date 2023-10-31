using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;
using MiasHR.Api.Entities;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MiasHR.Api.Controllers
{
    [ApiController]
    public class DayTimeOffRequestController : ControllerBase
    {
        private readonly IDayTimeOffRequestRepository _dayTimeOffRequestRepository;
        public DayTimeOffRequestController(IDayTimeOffRequestRepository dayTimeOffRequestRepository)
        {
            _dayTimeOffRequestRepository = dayTimeOffRequestRepository;
        }

        // Getting for specific Employee

        [HttpGet("api/[controller]/[action]/{emplCode}")]
        public async Task<ActionResult<IReadOnlyList<HrWebRequest>>> GetAllEmployeeDayTimeOffRequestList(string emplCode)
        {
            try
            {
                var dayTimeOffRequests = await _dayTimeOffRequestRepository.GetAllEmployeeDayTimeOffRequestList(emplCode);

                return dayTimeOffRequests == null ? NotFound() : Ok(dayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<RequestResultDTO>> CreateDayTimeOffRequest(string emplCode,
                                                                                  string type,
                                                                                  string subType,
                                                                                  DateOnly fromDate,
                                                                                  DateOnly toDate,
                                                                                  string title,
                                                                                  string content,
                                                                                  string ip,
                                                                                  string user,
                                                                                  int hours,
                                                                                  decimal daysCnt,
                                                                                  TimeOnly time,
                                                                                  string sickDayYn)
        {
            try
            {
                var requestResult = await _dayTimeOffRequestRepository.CreateDayTimeOffRequest(emplCode, type, subType, fromDate,
                                                                                               toDate, title, content, ip, user,
                                                                                               hours, daysCnt, time, sickDayYn);
                
                return (requestResult is null || requestResult.status == "FAILURE") ? NotFound() : Ok(requestResult);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        [HttpGet("api/[controller]/[action]/{id}")]
        public async Task<ActionResult<HrWebRequest>> GetDayTimeOffRequest(int id)

        {
            try
            {
                var dayTimeOffRequest = await _dayTimeOffRequestRepository.GetDayTimeOffRequest(id);

                return dayTimeOffRequest == null ? NotFound() : Ok(dayTimeOffRequest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        [HttpPut]
        [Route("api/[controller]/[action]/{id}")]
        public async Task<ActionResult<RequestResultDTO>> DeleteDayTimeOffRequest(int id)
        {
            try
            {
                var deleteResult = await _dayTimeOffRequestRepository.DeleteDayTimeOffRequest(id);

                return (deleteResult is null || deleteResult.status == "FAILURE") ? NotFound() : Ok(deleteResult);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //GetDayTimeOffRemainingByEmployee
        [HttpGet]
        [Route("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<EmployeeDayTimeOffRemainingDTO>>? GetDayTimeOffRemainingByEmployee(string emplCode, string year)
        {
            try
            {
                var dayTimeOffRemaining = await _dayTimeOffRequestRepository.GetDayTimeOffRemainingByEmployee(emplCode, year);

                return dayTimeOffRemaining == null ? NotFound() : Ok(dayTimeOffRemaining);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //
        [HttpGet]
        [Route("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>>? GetEmployeeDayTimeOffHistoryList(string emplCode, string year)
        {
            try
            {
                var dayTimeOffHistory = await _dayTimeOffRequestRepository.GetEmployeeDayTimeOffHistoryList(emplCode, year);

                return dayTimeOffHistory == null ? NotFound() : Ok(dayTimeOffHistory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //
        [HttpGet]
        [Route("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffRequestResultDTO>>>? GetDayTimeOffRequestResultList(string emplCode, string year)

        {
            try
            {
                var dayTimeOffRemaining = await _dayTimeOffRequestRepository.GetDayTimeOffRequestResultList(emplCode, year);

                return dayTimeOffRemaining == null ? NotFound() : Ok(dayTimeOffRemaining);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //
        [HttpGet]
        [Route("api/Manager/[controller]/[action]/{managerEmplCode}")]
        public async Task<ActionResult<IReadOnlyList<PendingDayTimeOffApprovalDTO>>>? GetPendingDayTimeOffRequestList(string managerEmplCode)
        {
            try
            {
                var pendingDayTimeOffRequests = await _dayTimeOffRequestRepository.GetPendingDayTimeOffRequestList(managerEmplCode);

                return pendingDayTimeOffRequests == null ? NotFound() : Ok(pendingDayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //
        [HttpGet]

        [Route("api/Manager/[controller]/[action]/{managerEmplCode}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>>? GetHrDayTimeOffApprovalHistory(string managerEmplCode)
        {
            try
            {
                var pendingDayTimeOffRequests = await _dayTimeOffRequestRepository.GetHrDayTimeOffApprovalHistory(managerEmplCode);

                return pendingDayTimeOffRequests == null ? NotFound() : Ok(pendingDayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }
    }
}

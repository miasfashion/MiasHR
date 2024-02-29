using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;
using MiasHR.Api.Entities;
using Microsoft.AspNetCore.Authorization;

namespace MiasHR.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class DayTimeOffRequestController : ControllerBase
    {
        private readonly IDayTimeOffRequestRepository _dayTimeOffRequestRepository;
        public DayTimeOffRequestController(IDayTimeOffRequestRepository dayTimeOffRequestRepository)
        {
            _dayTimeOffRequestRepository = dayTimeOffRequestRepository;
        }

        // Getting for specific Employee

        [HttpGet("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffRequestDTO>>> GetAllEmployeeDayTimeOffRequestList(string emplCode, string year)
        {
            try
            {
                var dayTimeOffRequests = await _dayTimeOffRequestRepository.GetAllEmployeeDayTimeOffRequestList(emplCode, year);
                var test = dayTimeOffRequests.ToList();
                return test;
                //return dayTimeOffRequests is null ? NotFound() : Ok(dayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<RequestResultDTO>> CreateDayTimeOffRequest(CreateRequestDTO request)
        {
            try
            {
                var requestResult = await _dayTimeOffRequestRepository.CreateDayTimeOffRequest(request.emplCode, request.type, request.subType, request.fromDate,
                                                                                               request.toDate, request.title, request.content, request.user,
                                                                                               request.hours, request.daysCnt, request.time, request.sickDayYn);

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

                return dayTimeOffRequest is null ? NotFound() : Ok(dayTimeOffRequest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        [HttpPost]
        [Route("api/[controller]/[action]/{id}/{emplCode}")]
        public async Task<ActionResult<string>> CancelDayTimeOffRequest(int id, string emplCode)
        {
            try
            {
                var deleteResult = await _dayTimeOffRequestRepository.CancelDayTimeOffRequest(id, emplCode);
                return deleteResult;

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> GetSickDaysRemaining([FromBody] string emplCode)
        {
            try
            {
                var remainDay = await _dayTimeOffRequestRepository.GetSickDaysRemaining(emplCode);
                return remainDay;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                     "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> GetVacationRemaining([FromBody] string emplCode)
        {
            try
            {
                var remainDay = await _dayTimeOffRequestRepository.GetVacationRemaining(emplCode);
                return remainDay;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                     "Error retrieving data from database");
            }
        }

        /*
        [HttpGet]
        [Route("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>>? GetEmployeeDayTimeOffHistoryList(string emplCode, string year)
        {
            try
            {
                var dayTimeOffHistory = await _dayTimeOffRequestRepository.GetEmployeeDayTimeOffHistoryList(emplCode, year);

                return dayTimeOffHistory is null ? NotFound() : Ok(dayTimeOffHistory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }
        */
        /*
        //
        [HttpGet]
        [Route("api/[controller]/[action]/{emplCode}/{year}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffRequestResultDTO>>>? GetDayTimeOffRequestResultList(string emplCode, string year)

        {
            try
            {
                var dayTimeOffRemaining = await _dayTimeOffRequestRepository.GetDayTimeOffRequestResultList(emplCode, year);

                return dayTimeOffRemaining is null ? NotFound() : Ok(dayTimeOffRemaining);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }
        */
        /*
        [HttpGet]
        [Route("api/Manager/[controller]/[action]/{managerEmplCode}")]
        public async Task<ActionResult<IReadOnlyList<PendingDayTimeOffApprovalDTO>>>? GetPendingDayTimeOffRequestList(string managerEmplCode)
        {
            try
            {
                var pendingDayTimeOffRequests = await _dayTimeOffRequestRepository.GetPendingDayTimeOffRequestList(managerEmplCode);

                return pendingDayTimeOffRequests is null ? NotFound() : Ok(pendingDayTimeOffRequests);
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

                return pendingDayTimeOffRequests is null ? NotFound() : Ok(pendingDayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }*/
    }
}

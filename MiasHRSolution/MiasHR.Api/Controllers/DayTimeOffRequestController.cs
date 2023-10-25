using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;
using MiasHR.Api.Entities;

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

        [HttpGet("api/[controller]/[action]/{empl_code}")]
        public async Task<ActionResult<IReadOnlyList<HrWebRequest>>> GetAllEmployeeDayTimeOffRequestList(string empl_code)
        {
            try
            {
                var dayTimeOffRequests = await _dayTimeOffRequestRepository.GetAllEmployeeDayTimeOffRequestList(empl_code);

                return dayTimeOffRequests == null ? NotFound() : Ok(dayTimeOffRequests);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<int>> CreateDayTimeOffRequest()
        {
            throw new NotImplementedException();
        }


        [HttpPut("api/[controller]/[action]/{Id}")]
        public async Task<ActionResult<int>> UpdateDayTimeOffRequest()
        {
            throw new NotImplementedException();
        }

        [HttpGet("api/[controller]/[action]/{Id}")]
        public async Task<ActionResult<HrWebRequest>> GetDayTimeOffRequest(int Id)

        {
            try
            {
                var dayTimeOffRequest = await _dayTimeOffRequestRepository.GetDayTimeOffRequest(Id);

                return dayTimeOffRequest == null ? NotFound() : Ok(dayTimeOffRequest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        [HttpPut]
        [Route("api/[controller]/[action]/{Id}")]
        public async Task<ActionResult<int>> DeleteDayTimeOffRequest(int Id)
        {
            try
            {
                var deleteResult = await _dayTimeOffRequestRepository.DeleteDayTimeOffRequest(Id);

                return deleteResult == 0 ? NotFound() : Ok(deleteResult);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                     "Error retrieving data from database");
            }
        }

        //GetDayTimeOffRemainingByEmployee
        [HttpGet]
        [Route("api/[controller]/[action]/{empl_code}/{year}")]
        public async Task<ActionResult<EmployeeDayTimeOffRemainingDTO>>? GetDayTimeOffRemainingByEmployee(string empl_code, string year)
        {
            try
            {
                var dayTimeOffRemaining = await _dayTimeOffRequestRepository.GetDayTimeOffRemainingByEmployee(empl_code, year);

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
        [Route("api/[controller]/[action]/{empl_code}/{year}")]
        public async Task<ActionResult<IReadOnlyList<EmployeeDayTimeOffHistoryDTO>>>? GetEmployeeDayTimeOffHistoryList(string empl_code, string year)
        {
            try
            {
                var dayTimeOffHistory = await _dayTimeOffRequestRepository.GetEmployeeDayTimeOffHistoryList(empl_code, year);

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
        [Route("api/[controller]/[action]/{empl_code}/{year}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffRequestResultDTO>>>? GetDayTimeOffRequestResultList(string empl_code, string year)

        {
            try
            {
                var dayTimeOffRemaining = await _dayTimeOffRequestRepository.GetDayTimeOffRequestResultList(empl_code, year);

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
        [Route("api/Manager/[controller]/[action]/{manager_empl_code}")]
        public async Task<ActionResult<IReadOnlyList<PendingDayTimeOffApprovalDTO>>>? GetPendingDayTimeOffRequestList(string manager_empl_code)
        {
            try
            {
                var pendingDayTimeOffRequests = await _dayTimeOffRequestRepository.GetPendingDayTimeOffRequestList(manager_empl_code);

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

        [Route("api/Manager/[controller]/[action]/{manager_empl_code}")]
        public async Task<ActionResult<IReadOnlyList<DayTimeOffApprovalHistoryDTO>>>? GetHrDayTimeOffApprovalHistories(string manager_empl_code)
        {
            try
            {
                var pendingDayTimeOffRequests = await _dayTimeOffRequestRepository.GetHrDayTimeOffApprovalHistories(manager_empl_code);

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

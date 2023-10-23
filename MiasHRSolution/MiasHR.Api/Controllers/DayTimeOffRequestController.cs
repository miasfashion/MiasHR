using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DayTimeOffRequestController : ControllerBase
    {
        private readonly IDayTimeOffRequestRepository _dayTimeOffRequestRepository;
        public DayTimeOffRequestController(IDayTimeOffRequestRepository dayTimeOffRequestRepository)
        {
            _dayTimeOffRequestRepository = dayTimeOffRequestRepository;
        }

        // Getting for specific Employee
        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<DayTimeOffRequestDTO>>> GetAllEmployeeDayTimeOffRequests(string empl_code)
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

        [HttpPost]
        public async Task<ActionResult<int>> CreateDayTimeOffRequest()
        { 
            throw new NotImplementedException();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<int>> UpdateDayTimeOffRequest(int Id, DayTimeOffRequestDTO dayTimeOffRequestDTO)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<DayTimeOffRequestDTO>> GetDayTimeOffRequest(int Id)
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
        [Route("DeleteDayTimeOffRequest/{Id}")]
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
        [Route("GetDayTimeOffRemainingByEmployee/{empl_code}/{year}")]
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
        [Route("GetEmployeeDayTimeOffHistoryList/{empl_code}/{year}")]
        public async Task<ActionResult<EmployeeDayTimeOffRemainingDTO>>? GetEmployeeDayTimeOffHistoryList(string empl_code, string year)
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
        [Route("GetDayTimeOffRequestResultList/{empl_code}/{year}")]
        public async Task<ActionResult<EmployeeDayTimeOffRemainingDTO>>? GetDayTimeOffRequestResultList(string empl_code, string year)
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
        [Route("GetPendingDayTimeOffRequestList/{manager_empl_code}")]
        public async Task<ActionResult<PendingDayTimeOffApprovalDTO>>? GetPendingDayTimeOffRequestList(string manager_empl_code)
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
        [Route("GetHrDayTimeOffApprovalHistories/{manager_empl_code}")]
        public async Task<ActionResult<PendingDayTimeOffApprovalDTO>>? GetHrDayTimeOffApprovalHistories(string manager_empl_code)
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

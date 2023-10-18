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
            this._dayTimeOffRequestRepository = dayTimeOffRequestRepository;
        }

        // Getting for specific Employee
        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<DayTimeOffRequestDTO>>> GetAllEmployeeDayTimeOffRequests(string empl_code)
        {
            try
            {
                var dayTimeOffRequests = await this._dayTimeOffRequestRepository.GetAllEmployeeDayTimeOffRequests(empl_code);
                
                if (dayTimeOffRequests == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(dayTimeOffRequests);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }
    }
}

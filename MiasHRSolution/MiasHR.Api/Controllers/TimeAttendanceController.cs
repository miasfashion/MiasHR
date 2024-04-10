using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class TimeAttendanceController : ControllerBase
    {
        private readonly ITimeAttendanceRepository _timeAttendanceRepository;
        
        public TimeAttendanceController(ITimeAttendanceRepository timeAttendanceRepository)
        {
            _timeAttendanceRepository = timeAttendanceRepository;
        }

        /// <summary>
        /// Retrieves the attendance history of an employee within a specified date range.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="dateFrom">The start date of the date range.</param>
        /// <param name="dateTo">The end date of the date range.</param>
        /// <returns>A list of HrEmployeeTimeHistory objects.</returns>
        [HttpPost("api/[controller]/[action]/")]
        public async Task<ActionResult<IReadOnlyList<EmployeeTimeHistoryDTO>>> GetHrEmployeeTimeHistory(TimeAttendanceDTO request)
        {
            try
            {
                string dateFromString = request.DateFrom.ToString("yyyyMMdd");
                string dateToString = request.DateTo.ToString("yyyyMMdd");
                var hrEmployeeTimeHistory = await _timeAttendanceRepository.GetHrEmployeeTimeHistory(request.EmplCode, dateFromString, dateToString);

                return hrEmployeeTimeHistory is null ? NotFound() : Ok(hrEmployeeTimeHistory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpPost("api/[controller]/[action]")]
        /// <summary>
        /// Retrieves the time list of an employee within a specified date range.
        /// </summary>
        /// <param name="emplCode">The employee code.</param>
        /// <param name="dateFrom">The start date of the date range.</param>
        /// <param name="dateTo">The end date of the date range.</param>
        /// <returns>A list of HrEmployeeTimeList objects.</returns>
        public async Task<ActionResult<EmployeeTimeListDTO>> GetEmployeeTimeList(TimeAttendanceDTO request)
        {
            try
            {
                string dateFromString = request.DateFrom.ToString("yyyyMMdd");
                string dateToString = request.DateTo.ToString("yyyyMMdd");
                var hrEmployeeTimeList = await _timeAttendanceRepository.GetEmployeeTimeList(request.EmplCode, dateFromString, dateToString);

                return hrEmployeeTimeList is null ? NotFound() : Ok(hrEmployeeTimeList);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                          "Error retrieving data from database");
            }
        }
    }
}

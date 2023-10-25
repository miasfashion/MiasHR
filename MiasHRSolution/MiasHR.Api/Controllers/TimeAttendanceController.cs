﻿using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TimeAttendanceController : ControllerBase
    {
        private readonly ITimeAttendanceRepository _timeAttendanceRepository;
        
        public TimeAttendanceController(ITimeAttendanceRepository timeAttendanceRepository)
        {
            _timeAttendanceRepository = timeAttendanceRepository;
        }

        /// <summary>
        /// Retrieves the time history of an employee within a specified date range.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="dateFrom">The start date of the date range.</param>
        /// <param name="dateTo">The end date of the date range.</param>
        /// <returns>A list of HrEmployeeTimeHistory objects.</returns>
        [HttpGet("{empl_code}/{dateFrom}/{dateTo}")]
        public async Task<ActionResult<IEnumerable<EmployeeTimeHistoryDTO>>> GetHrEmployeeTimeHistory(string empl_code, DateOnly dateFrom, DateOnly dateTo)
        {
            try
            {
                string dateFromString = dateFrom.ToString("yyyyMMdd");
                string dateToString = dateTo.ToString("yyyyMMdd");
                var hrEmployeeTimeHistory = await _timeAttendanceRepository.GetHrEmployeeTimeHistory(empl_code, dateFromString, dateToString);

                return hrEmployeeTimeHistory == null ? NotFound() : Ok(hrEmployeeTimeHistory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpGet("{empl_code}/{dateFrom}/{dateTo}")]
        /// <summary>
        /// Retrieves the time list of an employee within a specified date range.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="dateFrom">The start date of the date range.</param>
        /// <param name="dateTo">The end date of the date range.</param>
        /// <returns>A list of HrEmployeeTimeList objects.</returns>
        public async Task<ActionResult<EmployeeTimeListDTO>> GetEmployeeTimeList(string empl_code, DateOnly dateFrom, DateOnly dateTo)
        {
            try
            {
                string dateFromString = dateFrom.ToString("yyyyMMdd");
                string dateToString = dateTo.ToString("yyyyMMdd");
                var hrEmployeeTimeList = await _timeAttendanceRepository.GetEmployeeTimeList(empl_code, dateFromString, dateToString);

                return hrEmployeeTimeList == null ? NotFound() : Ok(hrEmployeeTimeList);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                          "Error retrieving data from database");
            }
        }
    }
}
using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;
using System.Linq.Expressions;

namespace MiasHR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeInfoRequestController : ControllerBase
    {
        private readonly IEmployeeInfoRequestRepository _employeeInfoRequestRepository;

        public EmployeeInfoRequestController(IEmployeeInfoRequestRepository employeeInfoRequestRepository)
        {
            this._employeeInfoRequestRepository = employeeInfoRequestRepository;
        }

        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<EmployeeInfoRequestDTO>>> GetBasicEmployeeInfo(string empl_code)
        {
            try
            {
                var employeeInfoRequests = await this._employeeInfoRequestRepository.GetBasicEmployeeInfo(empl_code);

                if (employeeInfoRequests == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employeeInfoRequests);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeInfoRequestDTO>>> GetAllEmployeeInfo()
        {
            try
            {
                var employeesInfo = await this._employeeInfoRequestRepository.GetAllEmployeeInfo();

                if (employeesInfo == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employeesInfo);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }

        }

        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<EmployeeDetailDTO>>> GetDetailEmployeeInfo(string empl_code)
        {
            try
            {
                var employeeDetailInfo = await this._employeeInfoRequestRepository.GetDetailEmployeeInfo(empl_code);

                if (employeeDetailInfo == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employeeDetailInfo);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }

        }

        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<TransferHistoryDTO>>> GetEmployeeTransferHistory(string empl_code)
        {
            try
            {
                var employeeTransfer = await this._employeeInfoRequestRepository.GetEmployeeTransferHistory(empl_code);

                if(employeeTransfer == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employeeTransfer);

                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IEnumerable<ADHistoryDTO>>> GetEmployeeAwardDiscHistory(string empl_code)
        {
            try
            {
                var employeeAward = await this._employeeInfoRequestRepository.GetEmployeeAwardDiscHistory(empl_code);

                if (employeeAward == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employeeAward);

                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpPut("{empl_code}")]
        public async Task<ActionResult<int>> UpdateUserPassword(string empl_code, string newPass)
        {
            try
            {
                var employeePassword = await this._employeeInfoRequestRepository.UpdateUserPassword(empl_code, newPass);
                if (employeePassword == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(employeePassword);
                }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

    }
}

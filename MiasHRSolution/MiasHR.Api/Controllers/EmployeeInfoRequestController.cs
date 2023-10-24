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

        //Get Employee's basic information
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IEnumerable<EmployeeInfoRequestDTO>>> GetBasicEmployeeInfo(string emplCode)
        {
            try
            {
                var employeeInfoRequests = await this._employeeInfoRequestRepository.GetBasicEmployeeInfo(emplCode);

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

        //Get all Active Employees' information
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

        //Get Personal Information of Employee
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IEnumerable<EmployeeDetailDTO>>> GetDetailEmployeeInfo(string emplCode)
        {
            try
            {
                var employeeDetailInfo = await this._employeeInfoRequestRepository.GetDetailEmployeeInfo(emplCode);

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

        //Get Transfer History of Employee
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IEnumerable<TransferHistoryDTO>>> GetEmployeeTransferHistory(string emplCode)
        {
            try
            {
                var employeeTransfer = await this._employeeInfoRequestRepository.GetEmployeeTransferHistory(emplCode);

                if (employeeTransfer == null)
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

        //Get Award And Disciplinary History of Employee 
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IEnumerable<ADHistoryDTO>>> GetEmployeeAwardDiscHistory(string emplCode)
        {
            try
            {
                var employeeAward = await this._employeeInfoRequestRepository.GetEmployeeAwardDiscHistory(emplCode);

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

        //Update User's Password
        [HttpPut("{emplCode}")]
        public ActionResult<int> UpdateUserPassword(string emplCode, string newPass)
        {
            try
            {
                var employeePassword = this._employeeInfoRequestRepository.UpdateUserPassword(emplCode, newPass);
                if (employeePassword == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(employeePassword);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        //Get the List of Employee for Manager
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IEnumerable<ManagerEmployeeListDTO>>> GetManagerEmployeeList(string emplCode)
        {
            try
            {
                var managingEmployee = await this._employeeInfoRequestRepository.GetManagerEmployeeList(emplCode);
                if (managingEmployee == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(managingEmployee);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

    }
}

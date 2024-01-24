using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using MiasHR.Models.DTOs;
using MiasHR.Api.Entities;
using Microsoft.AspNetCore.Authorization;

namespace MiasHR.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeInfoRequestController : ControllerBase
    {
        private readonly IEmployeeInfoRequestRepository _employeeInfoRequestRepository;

        public EmployeeInfoRequestController(IEmployeeInfoRequestRepository employeeInfoRequestRepository)
        {
            _employeeInfoRequestRepository = employeeInfoRequestRepository;
        }

        //Get Employee's basic information
        [HttpGet("{emplCode}")]
        public async Task<ActionResult<HrEmployee>> GetBasicEmployeeInfo(string emplCode)
        {
            try
            {
                var employeeInfoRequests = await _employeeInfoRequestRepository.GetBasicEmployeeInfo(emplCode);

                if (employeeInfoRequests is null)
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
        public async Task<ActionResult<IReadOnlyList<HrEmployee>>> GetAllEmployeeInfo()
        {
            try
            {
                var employeesInfo = await _employeeInfoRequestRepository.GetAllEmployeeInfo();

                if (employeesInfo is null)
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
        public async Task<ActionResult<HrEmployeeDetail>> GetDetailEmployeeInfo(string emplCode)
        {
            try
            {
                var employeeDetailInfo = await _employeeInfoRequestRepository.GetDetailEmployeeInfo(emplCode);

                if (employeeDetailInfo is null)
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
        public async Task<ActionResult<IReadOnlyList<TransferHistoryDTO>>> GetEmployeeTransferHistory(string emplCode)
        {
            try
            {
                var employeeTransfer = await _employeeInfoRequestRepository.GetEmployeeTransferHistory(emplCode);

                if (employeeTransfer is null)
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
        public async Task<ActionResult<IReadOnlyList<ADHistoryDTO>>> GetEmployeeAwardDiscHistory(string emplCode)
        {
            try
            {
                var employeeAward = await _employeeInfoRequestRepository.GetEmployeeAwardDiscHistory(emplCode);

                if (employeeAward is null)
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
        public async Task<ActionResult<RequestResultDTO>> UpdateUserPassword(string emplCode, string newPass)
        {
            try
            {
                var employeePassword = await _employeeInfoRequestRepository.UpdateUserPassword(emplCode, newPass);
                if (employeePassword is null)
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
        public async Task<ActionResult<IReadOnlyList<ManagerEmployeeListDTO>>> GetManagerEmployeeList(string emplCode)
        {
            try
            {
                var managingEmployee = await _employeeInfoRequestRepository.GetManagerEmployeeList(emplCode);
                if (managingEmployee is null)
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

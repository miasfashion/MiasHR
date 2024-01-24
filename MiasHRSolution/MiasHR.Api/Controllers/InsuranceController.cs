using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceRepository _insuranceRepository;
        
        public InsuranceController(IInsuranceRepository insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }

        [HttpGet("{emplCode}")]
        public async Task<ActionResult<IReadOnlyList<InsuranceSurfingDTO>>> GetSelectedInsurance(string emplCode)
        {
            try
            {
                var selectedInsurance = await _insuranceRepository.GetSelectedInsurance(emplCode);

                return selectedInsurance is null ? NotFound() : Ok(selectedInsurance);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpGet("{insuranceType}/{emplCode}/{selectedCoverage}")]
        public async Task<ActionResult<IReadOnlyList<InsuranceSurfingDTO>>> GetInsuranceOptions(string insuranceType, string emplCode, string selectedCoverage)
        {
            try
            {
                var insuranceOptions = await _insuranceRepository.GetInsuranceOptions(insuranceType, emplCode, selectedCoverage);

                return insuranceOptions is null ? NotFound() : Ok(insuranceOptions);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpPut("{insuranceType}/{emplCode}/{selectedCoverage}/{selectedSurfingId}")]
        public async Task<ActionResult<RequestResultDTO>> UpdateInsuranceOption(string insuranceType, string emplCode, string selectedCoverage, int selectedSurfingId)
        {
            try
            {
                var updateResult = await _insuranceRepository.UpdateInsuranceOption(insuranceType, emplCode, selectedCoverage, selectedSurfingId);

                return (updateResult is null || updateResult.status == "FAILURE") ? BadRequest() : Ok(updateResult);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }
    }
}

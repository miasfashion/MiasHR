using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
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

                return selectedInsurance == null ? NotFound() : Ok(selectedInsurance);
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

                return insuranceOptions == null ? NotFound() : Ok(insuranceOptions);
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

                return updateResult.status == "SUCCESSFUL" ? Ok(updateResult) : BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }
    }
}

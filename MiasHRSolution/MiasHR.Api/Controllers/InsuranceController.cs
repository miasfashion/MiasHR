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

        [HttpGet("{empl_code}")]
        public async Task<ActionResult<IReadOnlyList<InsuranceSurfingDTO>>> GetSelectedInsurance(string empl_code)
        {
            try
            {
                var selectedInsurance = await _insuranceRepository.GetSelectedInsurance(empl_code);

                return selectedInsurance == null ? NotFound() : Ok(selectedInsurance);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpGet("{insurance_type}/{empl_code}/{selected_coverage}")]
        public async Task<ActionResult<IReadOnlyList<InsuranceSurfingDTO>>> GetInsuranceOptions(string insurance_type, string empl_code, string selected_coverage)
        {
            try
            {
                var selectedInsurance = await _insuranceRepository.GetInsuranceOptions(insurance_type, empl_code, selected_coverage);

                return selectedInsurance == null ? NotFound() : Ok(selectedInsurance);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }

        [HttpPut("{insurance_type}/{empl_code}/{selected_coverage}/{selected_surfing_id}")]
        public ActionResult<string> UpdateInsuranceOption(string insurance_type, string empl_code, string selected_coverage, int selected_surfing_id)
        {
            try
            {
                var selectedInsurance = _insuranceRepository.UpdateInsuranceOption(insurance_type, empl_code, selected_coverage, selected_surfing_id);

                return selectedInsurance == null ? NotFound() : Ok(selectedInsurance);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                       "Error retrieving data from database");
            }
        }
    }
}

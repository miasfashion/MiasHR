using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EvaluationController : ControllerBase
    {
        private readonly IEvaluationRepository _evaluationRepository;
        public EvaluationController(IEvaluationRepository evaluationRepository)
        {
            _evaluationRepository = evaluationRepository;
        }

        //Get Evaluation Factor Information for employee
        [HttpGet("api/[controller]/[action]/{empl_code}")]
        public async Task<ActionResult<IReadOnlyList<FactorEvalDTO>>> GetEvaluationFactors(string empl_code, string year, string term)
        {
            try
            {
                var evaluationFactor = await _evaluationRepository.GetEvaluationFactors(empl_code, year, term);
                if (evaluationFactor == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(evaluationFactor);
                }
            }
            catch (Exception) 
            { 
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }

        }

        //Insert Self Evaluation Record to the DB
        [HttpPost("api/[controller]/[action]/{empl_code}")]
        public async Task<ActionResult<UpdateMessageDTO>> CreateSelfEvaluation (string empl_code, string year, string term, string comment, string factor, string grade)
        {
            try
            {
                var selfEval = await _evaluationRepository.CreateSelfEvaluation(empl_code, year, term,comment,factor,grade);
                if (selfEval is not null && selfEval.msg == "Saved Successfully!")
                {
                    return Ok(selfEval);
                }
                else
                {
                    return NotFound(selfEval);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

    }
}

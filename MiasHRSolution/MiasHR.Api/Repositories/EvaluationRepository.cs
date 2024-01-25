using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MiasHR.Api.Repositories
{
    public class EvaluationRepository : IEvaluationRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public EvaluationRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieve Evaluation Factors for specific Employee 
        /// </summary>
        /// <param name="emplCode">The employee code</param>
        /// <param name="year">Year of the Evaluation</param>
        /// <param name="term">Term of the Evaluation</param>
        /// <returns>All the Evaluation factors for the employee with grading scale</returns>
        public async Task<IReadOnlyList<FactorEvalDTO>> GetEvaluationFactors(string emplCode, string year, string term)
        {
            var param = new
            {
                pMode = "FACTOREVAL",
                pEmplCode = emplCode,
                pYear = year,
                pTerm = term,
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FactorEvalDTO>(
                    "sp_HR_EvalSelf",
                    param,
                    commandType: CommandType.StoredProcedure);
                return result.ToList().AsReadOnly();
            }
        }

        /// <summary>
        /// Insert Self Evaluation content for specific Employee 
        /// </summary>
        /// <param name="emplCode">The employee code</param>
        /// <param name="year">Year of the Evaluation</param>
        /// <param name="term">Term of the Evaluation</param>
        /// <param name="comment">Comment left by employee</param>
        /// <param name="factor">Factor that employee is evaluating</param>
        /// <param name="grade">Grade employee gave for the factor</param>
        /// <returns>Whether self evaluation was successful or not</returns>
        public async Task<RequestResultDTO> CreateSelfEvaluation(string emplCode, string year, string term, string factor, string grade, string comment = "")
        {
            RequestResultDTO requestResultDTO = new RequestResultDTO("FAILURE", null);
            var param = new
            {
                pMode = "SELFEVAL",
                pEmplCode = emplCode,
                pYear = year,
                pTerm = term,
                pComment = comment,
                pFactor = factor,
                pFactorGrade = grade

            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<UpdateMessageDTO>(
                    "sp_HR_EvalSelf",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                if (result is not null && result.msg == "Saved Successfully!")
                {
                    requestResultDTO.status = "SUCCESS";
                    requestResultDTO.data = new Dictionary<string, dynamic>();
                    requestResultDTO.data.Add("emplCode", emplCode);
                    requestResultDTO.data.Add("year", year);
                    requestResultDTO.data.Add("term", term);
                    requestResultDTO.data.Add("factor", factor);
                    requestResultDTO.data.Add("grade", grade);
                    requestResultDTO.data.Add("comment", comment);
                }
                return requestResultDTO;
            }
        }

    }
}

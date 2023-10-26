using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEvaluationRepository
    {
        Task<IReadOnlyList<FactorEvalDTO>> GetEvaluationFactors(string empl_code, string year, string term); 
        Task<UpdateMessageDTO> CreateSelfEvaluation(string empl_code, string year, string term, string comment, string factor, string grade );
    }
}

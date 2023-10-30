using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEvaluationRepository
    {
        Task<IReadOnlyList<FactorEvalDTO>> GetEvaluationFactors(string emplCode, string year, string term); 
        Task<UpdateMessageDTO> CreateSelfEvaluation(string emplCode, string year, string term, string comment, string factor, string grade );
    }
}

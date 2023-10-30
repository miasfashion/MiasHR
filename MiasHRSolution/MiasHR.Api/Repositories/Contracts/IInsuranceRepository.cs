using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IInsuranceRepository
    {
        Task<IReadOnlyList<InsuranceSurfingDTO>> GetSelectedInsurance(string emplCode);

        Task<IReadOnlyList<InsuranceSurfingDTO>> GetInsuranceOptions(string insuranceType, string emplCode, string selectedCoverage);

        Task<UpdateMessageDTO> UpdateInsuranceOption(string insuranceType, string emplCode, string selectedCoverage, int selectedSurfingId);
    }
}

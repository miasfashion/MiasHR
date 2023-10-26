using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IInsuranceRepository
    {
        Task<IReadOnlyList<InsuranceSurfingDTO>> GetSelectedInsurance(string empl_code);

        Task<IReadOnlyList<InsuranceSurfingDTO>> GetInsuranceOptions(string insurance_type, string empl_code, string selected_coverage);

        Task<UpdateMessageDTO> UpdateInsuranceOption(string insurance_type, string empl_code, string selected_coverage, int selected_surfing_id);
    }
}

using MiasHR.Models.DTOs;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IInsuranceRepository
    {
        Task<IReadOnlyList<InsuranceSurfingDTO>> GetSelectedInsurance(int empl_code);

        Task<IReadOnlyList<InsuranceSurfingDTO>> GetInsuranceOptions(string insurance_type, int empl_code, string selected_coverage);

        string UpdateInsuranceOption(string insurance_type, int empl_code, string selected_coverage, int selected_surfing_id);
    }
}

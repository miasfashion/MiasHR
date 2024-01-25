namespace MiasHR.Models.DTOs
{
    public class InsuranceSurfingDTO
    {
        public int plan_id { get; }
        public string? contract_code { get; }
        public string? file_path { get; }
        public string? plan_name { get; }
        public string? plan_type { get; }
        public int surfing_id { get; }
        public string? bundle_yn { get; }
        public decimal? ins_amt { get; }
        public decimal? empl_pay { get; }
        public decimal? company_pay { get; }
        public string? coverage_desc { get; }
    }
}

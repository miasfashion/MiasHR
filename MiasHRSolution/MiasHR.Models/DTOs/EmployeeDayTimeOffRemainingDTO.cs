namespace MiasHR.Models.DTOs
{
    public class EmployeeDayTimeOffRemainingDTO
    {
        public string? div_name { get; set; }

        public string? dept_name { get; set; }

        public int empl_code { get; set; }

        public string? name { get; set; }

        public string? hire_date { get; set; }

        public decimal? s_carry_over_days { get; set; }

        public decimal? s_year_basic_days { get; set; }

        public decimal? prev_month_day { get; set; }

        public decimal? accu_days { get; set; }

        public decimal? s_curr_basic_days { get; set; }

        public decimal? s_adjust_days { get; set; }

        public decimal? s_used_days { get; set; }

        public decimal? s_available_days { get; set; }

        public decimal? s_available_curr_days { get; set; }

        public decimal? s_available_curr_hrs { get; set; }

        public string? yyyy { get; set; }

        public decimal? s_left_days { get; set; }

        public decimal? s_hold_days { get; set; }

        public string? s_available_days_span { get; set; }

        public string? s_available_curr_days_span { get; set; }

        public string? payroll_org_code { get; set; }

        public decimal? s_available_asof_date { get; set; }

        public decimal? s_uto_days { get; set; }

        public decimal? s_uto_applied_days { get; set; }

        public string? resign_date { get; set; }

        public decimal? s_sick_days { get; set; }

        public decimal? s_used_sick_days { get; set; }

        public decimal? org_available_days { get; set; }
    }
}
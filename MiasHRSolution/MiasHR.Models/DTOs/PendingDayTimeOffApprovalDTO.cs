using System.ComponentModel.DataAnnotations.Schema;

namespace MiasHR.Models.DTOs
{
    public class PendingDayTimeOffApprovalDTO
    {
        public int seq { get; }

        public int status { get; }

        public string empl_code { get; }

        public string? req_date { get; }

        public string? req_type { get; }

        public string? req_sub_type { get; }

        public string? period_from { get; }

        public string? period_to { get; }

        public decimal? days_cnt { get; }

        public int? hours_cnt { get; }

        public TimeSpan? start_time { get; }

        public string? req_title { get; }

        public string? req_content { get; }

        public string? req_ip { get; }

        public string? approve_1st_yn { get; }

        public string? approve_1st_user { get; }

        public DateTime? approve_1st_date { get; }

        public string? approve_2nd_yn { get; }

        public string? approve_2nd_user { get; }

        public DateTime? approve_2nd_date { get; }

        public string? mhrs_update_yn { get; }

        public string? mhrs_update_user { get; }

        public string? reject_reason { get; }

        public string? reject_user { get; }

        public DateTime? reject_date { get; }

        public string? sickday_yn { get; }

        public DateTime? created_date { get; }

        public string? created_user { get; }

        public DateTime? modified_date { get; }

        public string? modified_user { get; }

        public string? approve_type { get; }

        public string? req_date2 { get; }

        public string? period { get; }

        public decimal? pto_left_days { get; }

        public decimal? pto_curr_days { get; }

        public decimal? sick_left_days { get; }

        public decimal? sick_curr_days { get; }

        public string? empl_name { get; }

        public string? div_name { get; }

        public string? dept_name { get; }

        public string? div_dept { get; }

        public string? left_days { get; }

        public string? curr_days { get; }

        public string? req_content3 { get; }
    }
}
namespace MiasHR.Models.DTOs
{
    public class DayTimeOffApprovalHistoryDTO
    {
        public int seq { get; }

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

        public string? empl_name { get; }

        public string? req_date2 { get; }

        public string? period { get; }

        public string? req_status { get; }

        public string? req_content2 { get; }

        public string? req_content3 { get; }

    }
}

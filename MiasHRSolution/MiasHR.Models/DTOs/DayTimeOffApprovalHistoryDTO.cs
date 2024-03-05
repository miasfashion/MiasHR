namespace MiasHR.Models.DTOs
{
    public class DayTimeOffApprovalHistoryDTO
    {
        public int seq { get; set; }

        public string? req_date { get; set; }

        public string? req_type { get; set; }

        public string? req_sub_type { get; set; }

        public string? period_from { get; set; }

        public string? period_to { get; set; }

        public decimal? days_cnt { get; set; }

        public int? hours_cnt { get; set; }

        public TimeSpan? start_time { get; set; }

        public string? req_title { get; set; }

        public string? req_content { get; set; }

        public string? req_ip { get; set; }

        public string? approve_1st_yn { get; set; }

        public string? approve_1st_user { get; set; }

        public DateTime? approve_1st_date { get; set; }

        public string? approve_2nd_yn { get; set; }

        public string? approve_2nd_user { get; set; }

        public DateTime? approve_2nd_date { get; set; }

        public string? mhrs_update_yn { get; set; }

        public string? mhrs_update_user { get; set; }

        public string? reject_reason { get; set; }

        public string? reject_user { get; set; }

        public DateTime? reject_date { get; set; }

        public string? sickday_yn { get; set; }

        public string? empl_name { get; set; }

        public string? req_date2 { get; set; }

        public string? period { get; set; }

        public string? req_status { get; set; }

        public string? req_content2 { get; set; }

        public string? req_content3 { get; set; }

    }
}

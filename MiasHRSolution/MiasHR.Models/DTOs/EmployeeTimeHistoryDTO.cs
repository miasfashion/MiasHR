using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasHR.Models.DTOs
{
    public class EmployeeTimeHistoryDTO
    {
        public string? dept_name { get; }
        public string? empl_name { get; }
        public string? tdate { get; }
        public string? date { get; }
        public string? inout { get; }
        public string? day_type_desc { get; }
        public string? work_start_time { get; }
        public string? late_level { get; }
        public string? update_type { get; }
        public string? reason_desc { get; }
        public string? remark { get; }
        public string? period_desc { get; }
        public string? flsa { get; }
        public string? empl_code { get; }
    }
}

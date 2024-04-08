namespace MiasHR.Models.DTOs
{
    public class EmployeeTimeListDTO
    {
        public string empl_name { get; set; }
        public int day_cnt { get; set; }
        public int level_0_cnt { get; set; }
        public int level_1_cnt { get; set; }
        public int level_1_minutesum { get; set; }
        public int level_2_cnt { get; set; }
        public int manual_cnt { get; set; }
        public int lack_days { get; set; }
    }
}

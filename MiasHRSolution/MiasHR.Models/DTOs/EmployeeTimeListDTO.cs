namespace MiasHR.Models.DTOs
{
    public class EmployeeTimeListDTO
    {
        public string empl_name { get; }
        public int day_cnt { get; }
        public int level_0_cnt { get; }
        public int level_1_cnt { get; }
        public int level_1_minutesum { get; }
        public int level_2_cnt { get; }
        public int manual_cnt { get; }
        public int lack_days { get; }
    }
}

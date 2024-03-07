namespace MiasHR.Models.DTOs
{
    public class CreateRequestDTO
    {
        public string emplCode { get; set; }
        public string type { get; set; }
        public string subType { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set;}
        public string title { get; set; } = "";        
        public string content { get; set; }
        public string user { get; set; }
        public int hours { get; set; }
        public decimal daysCnt { get; set; }
        public TimeSpan time {  get; set; }
        public string sickDayYn { get; set; }
    }
}

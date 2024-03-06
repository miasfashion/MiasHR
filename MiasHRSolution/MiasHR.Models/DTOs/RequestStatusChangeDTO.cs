namespace MiasHR.Models.DTOs
{
    public class RequestStatusChangeDTO
    {
        public int id { get; set; }
        public string statusType { get; set; }
        public string managerEmplCode { get; set; }
        public string? rejectReason { get; set; }
    }
}

namespace MiasHR.Models.DTOs
{
    public class EmailDTO
    {
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string ApprovStep { get; set; } = string.Empty;
        public string role {  get; set; } = "Employee";
        public string managerEmployee { get; set; } = string.Empty;
        public string managerOther { get; set; } = string.Empty;
        public string managerNotice { get; set; } = string.Empty;
    }
}

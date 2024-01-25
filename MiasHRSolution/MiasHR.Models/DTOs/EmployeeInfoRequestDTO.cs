namespace MiasHR.Models.DTOs
{
    public class EmployeeInfoRequestDTO
    {
        public string EmplCode { get; set; } = null!;

        public string OrgCode { get; set; } = null!;

        public string? EmplType { get; set; }

//        public int Status { get; set; }

//        public string? ActiveYn { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? NickName { get; set; }

        public string? DivCode { get; set; }

        public string? DeptCode { get; set; }

        public string? UpperEmplCode { get; set; }

        public string? ComTel { get; set; }

        public string? ComTelExt { get; set; }

        public string? ComFax { get; set; }

        public string? ComEmail { get; set; }

//        public string? Position { get; set; }

//        public string? PositionYrs { get; set; }

//        public string? BuildingLoc { get; set; }

        public string? HireDate { get; set; }

//        public string? PtoHireDate { get; set; }

//        public string? ResignDate { get; set; }

//        public string? ResignReason { get; set; }

//        public string? TnaStatus { get; set; }

//        public string? BadgeCode { get; set; }

//        public string? PayrollCode { get; set; }

//        public string? PayrollOrgCode { get; set; }

//        public string? HourlybaseYn { get; set; }

        public byte[]? Photo { get; set; }

        public byte[]? PhotoThumbnail { get; set; }

        public string? Title { get; set; }

//        public string? BusinessTitle { get; set; }

//        public string? Other { get; set; }

//        public string? QbKey { get; set; }

//        public DateTime? QbSendDate { get; set; }

    }
}

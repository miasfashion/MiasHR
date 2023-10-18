using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeeAllHistory
{
    public int Seq { get; set; }

    public string EmplCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public int Status { get; set; }

    public string? ActiveYn { get; set; }

    public string? EmplType { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? NickName { get; set; }

    public string? DivCode { get; set; }

    public string? DeptCode { get; set; }

    public string? ComTel { get; set; }

    public string? ComTelExt { get; set; }

    public string? ComFax { get; set; }

    public string? ComEmail { get; set; }

    public string? Position { get; set; }

    public string? PositionYrs { get; set; }

    public string? BuildingLoc { get; set; }

    public string? HireDate { get; set; }

    public string? ResignDate { get; set; }

    public string? TnaStatus { get; set; }

    public string? BadgeCode { get; set; }

    public string? PayrollCode { get; set; }

    public string? PayrollOrgCode { get; set; }

    public string? HourlybaseYn { get; set; }

    public byte[]? Photo { get; set; }

    public string? Title { get; set; }

    public string? BusinessTitle { get; set; }

    public string? Gender { get; set; }

    public string? BirthDate { get; set; }

    public string? Degree { get; set; }

    public string? MarriedYn { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Street2 { get; set; }

    public string? City2 { get; set; }

    public string? State2 { get; set; }

    public string? Zip2 { get; set; }

    public string? Country2 { get; set; }

    public string? Tel { get; set; }

    public string? Cell { get; set; }

    public string? ResidentStatus { get; set; }

    public string? AlienNo { get; set; }

    public string? I9Date { get; set; }

    public byte[]? Ssn { get; set; }

    public string? W4Status { get; set; }

    public int? Exemptions { get; set; }

    public string? Memo { get; set; }

    public string? Contact1Name { get; set; }

    public string? Contact1Relationship { get; set; }

    public string? Contact1Addr1 { get; set; }

    public string? Contact1Addr2 { get; set; }

    public string? Contact1Tel { get; set; }

    public string? Contact1Cell { get; set; }

    public string? Contact2Name { get; set; }

    public string? Contact2Relationship { get; set; }

    public string? Contact2Addr1 { get; set; }

    public string? Contact2Addr2 { get; set; }

    public string? Contact2Tel { get; set; }

    public string? Contact2Cell { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }

    public string? PtoHireDate { get; set; }

    public string? ResignReason { get; set; }
}

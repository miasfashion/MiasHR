using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrIncident
{
    public string ManageNo { get; set; } = null!;

    public int Status { get; set; }

    public string OrgCode { get; set; } = null!;

    public string? Date { get; set; }

    public string? Ampm { get; set; }

    public string? Time { get; set; }

    public string? PersonType { get; set; }

    public string? EmplCode { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? HomeTel { get; set; }

    public string? WorkTel { get; set; }

    public string? OtherTel { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public string? AccidentPlace { get; set; }

    public string? Witness1Name { get; set; }

    public string? Witness1Tel { get; set; }

    public string? Witness2Name { get; set; }

    public string? Witness2Tel { get; set; }

    public string? Call911Yn { get; set; }

    public string? FirstAidYn { get; set; }

    public string? HospitalYn { get; set; }

    public string? DoctorCode { get; set; }

    public string? HospitalCode { get; set; }

    public string? WorkcompYn { get; set; }

    public string? WorkcompDesc { get; set; }

    public string? ReportedBy { get; set; }

    public string? ReportedDate { get; set; }

    public string? ReviewedBy { get; set; }

    public string? ReviewedDate { get; set; }

    public int? InjuredX { get; set; }

    public int? InjuredY { get; set; }

    public string? IncidentDesc { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

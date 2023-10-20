using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrAutoAccident
{
    public string ManageNo { get; set; } = null!;

    public int Status { get; set; }

    public string? ReportDate { get; set; }

    public string OrgCode { get; set; } = null!;

    public string? DeptCode { get; set; }

    public string? ReportEmplCode { get; set; }

    public string? AutoCode { get; set; }

    public string EmplCode { get; set; } = null!;

    public string? AutoPurpose { get; set; }

    public string? Date { get; set; }

    public string? Ampm { get; set; }

    public string? Time { get; set; }

    public string? AccidentPlace { get; set; }

    public string? AccidentDesc { get; set; }

    public string? OtherModel { get; set; }

    public string? OtherPlateNo { get; set; }

    public string? OtherVinNo { get; set; }

    public string? OtherName { get; set; }

    public string? OtherLicenseNo { get; set; }

    public string? OtherTel { get; set; }

    public string? OtherAutoDesc { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

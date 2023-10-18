using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrPayrollBenefit
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public short? Status { get; set; }

    public string? PayDate { get; set; }

    public string? Type { get; set; }

    public string? ContType { get; set; }

    public decimal? Benefit1 { get; set; }

    public decimal? Benefit2 { get; set; }

    public decimal? Benefit3 { get; set; }

    public decimal? Benefit4 { get; set; }

    public decimal? Benefit5 { get; set; }

    public decimal? BenefitAmt { get; set; }

    public decimal? AdjustAmt { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Id { get; set; }

    public string? Yyyymm { get; set; }

    public string? Remark { get; set; }

    public string? Remark2 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrInsEmplSurfing
{
    public string OrgCode { get; set; } = null!;

    public int SurfingId { get; set; }

    public int? Status { get; set; }

    public int PlanId { get; set; }

    public string EmplCode { get; set; } = null!;

    public string? Coverage { get; set; }

    public decimal? EeAmt { get; set; }

    public decimal? DepAmt { get; set; }

    public decimal? TotalAmt { get; set; }

    public decimal? OtherEeAmt { get; set; }

    public decimal? OtherEespAmt { get; set; }

    public decimal? OtherEechAmt { get; set; }

    public decimal? OtherFamAmt { get; set; }

    public decimal? OtherEeBundleAmt { get; set; }

    public decimal? OtherEespBundleAmt { get; set; }

    public decimal? OtherEechBundleAmt { get; set; }

    public decimal? OtherFamBundleAmt { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

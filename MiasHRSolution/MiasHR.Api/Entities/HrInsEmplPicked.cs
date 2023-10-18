using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrInsEmplPicked
{
    public string OrgCode { get; set; } = null!;

    public int InsPickedId { get; set; }

    public int? Status { get; set; }

    public string? EmplCode { get; set; }

    public int? SurfingId { get; set; }

    public int? PlanId { get; set; }

    public string? Coverage { get; set; }

    public decimal? EeAmt { get; set; }

    public decimal? DepAmt { get; set; }

    public decimal? TotalAmt { get; set; }

    public decimal? EePayAmt { get; set; }

    public decimal? CompanyPayAmt { get; set; }

    public string? BundleYn { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrInsPlan
{
    public string OrgCode { get; set; } = null!;

    public int PlanId { get; set; }

    public int? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public string? PlanType { get; set; }

    public string? PlanName { get; set; }

    public string? ContractCode { get; set; }

    public int? SortNo { get; set; }

    public string? PlanDesc { get; set; }

    public byte[]? PlanImage { get; set; }

    public string? OpenYn { get; set; }

    public decimal? PayRateForEe { get; set; }

    public decimal? PayRateForDep { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrInsNotEnroll
{
    public string OrgCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public string EmplCode { get; set; } = null!;

    public string PlanType { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

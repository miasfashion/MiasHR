using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaTime
{
    public string OrgCode { get; set; } = null!;

    public string Date { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string Inout { get; set; } = null!;

    public string? UpdateType { get; set; }

    public string? UpdateReason { get; set; }

    public string? WorkStartTime { get; set; }

    public string? WorkEndTime { get; set; }

    public string? LateLevel { get; set; }

    public string? Remark { get; set; }

    public string? BadgeCode { get; set; }

    public string? BadgeName { get; set; }

    public string? GroupCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalPromotionEmployee
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? OldPosition { get; set; }

    public string? NewPosition { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

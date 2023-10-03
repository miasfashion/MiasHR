using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalManager
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string? MgrGroupCode { get; set; }

    public string? Position { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

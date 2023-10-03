using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaDay
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public string? Date { get; set; }

    public int Status { get; set; }

    public string? DayType { get; set; }

    public string? StartTime { get; set; }

    public string? Remark { get; set; }

    public string? UtoAppliedYn { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

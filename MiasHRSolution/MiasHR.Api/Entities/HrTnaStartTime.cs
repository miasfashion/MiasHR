using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaStartTime
{
    public int Seq { get; set; }

    public string? EmplCode { get; set; }

    public int? Status { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? WorkStartTime { get; set; }

    public string? LateTime { get; set; }

    public string? Mon { get; set; }

    public string? Tue { get; set; }

    public string? Wed { get; set; }

    public string? Thu { get; set; }

    public string? Fri { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

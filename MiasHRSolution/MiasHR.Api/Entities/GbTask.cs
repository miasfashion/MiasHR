using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbTask
{
    public string OrgCode { get; set; } = null!;

    public string TaskCode { get; set; } = null!;

    public string? TaskDesc { get; set; }

    public int? Status { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

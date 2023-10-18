using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbTaskMember
{
    public string OrgCode { get; set; } = null!;

    public string TaskCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

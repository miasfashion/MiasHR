using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaUserGroup
{
    public string UserCode { get; set; } = null!;

    public string SysCode { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

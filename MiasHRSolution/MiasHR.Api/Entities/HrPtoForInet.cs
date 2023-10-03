using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrPtoForInet
{
    public string? UserId { get; set; }

    public string? OrgCode { get; set; }

    public string? EmplCode { get; set; }

    public string? EmplName { get; set; }

    public string? DayType { get; set; }

    public string? DayTypeDesc { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public DateTime? CrtDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaEmailNotice
{
    public string EmplCode { get; set; } = null!;

    public string Date { get; set; } = null!;

    public string? TypeDesc { get; set; }

    public string? SendDate { get; set; }

    public string? SendUser { get; set; }

    public DateTime? CrtDate { get; set; }
}

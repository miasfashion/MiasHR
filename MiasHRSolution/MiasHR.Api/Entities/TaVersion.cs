using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaVersion
{
    public string SysId { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string? ServerPath { get; set; }

    public string? LocalPath { get; set; }

    public string? Version { get; set; }

    public string? DllYn { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaCodeMapping
{
    public string Class { get; set; } = null!;

    public string OldCode { get; set; } = null!;

    public string? NewCode { get; set; }
}

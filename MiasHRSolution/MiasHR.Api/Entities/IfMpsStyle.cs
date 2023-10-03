using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfMpsStyle
{
    public int MpsStyleId { get; set; }

    public string? MpsStyle { get; set; }

    public string? MpsStyleDesc { get; set; }

    public byte[]? MpsStyleImage { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}

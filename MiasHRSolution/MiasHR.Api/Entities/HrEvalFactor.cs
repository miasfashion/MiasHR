using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalFactor
{
    public string Factor { get; set; } = null!;

    public string? FactorDesc { get; set; }

    public short? Status { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

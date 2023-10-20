using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalBasic
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public short? EvalPer { get; set; }

    public decimal? PointFrom { get; set; }

    public decimal? PointTo { get; set; }

    public short? DistributePer { get; set; }

    public string? PFrom { get; set; }

    public string? PTo { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalEmployeeResult
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string Factor { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? S1Grade { get; set; }

    public short? S1FactorPoint { get; set; }

    public string? S2Grade { get; set; }

    public short? S2FactorPoint { get; set; }

    public string? S3Grade { get; set; }

    public short? S3FactorPoint { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

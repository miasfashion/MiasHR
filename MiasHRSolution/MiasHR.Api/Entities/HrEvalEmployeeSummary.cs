using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalEmployeeSummary
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string? Position { get; set; }

    public string? PositionYrs { get; set; }

    public string? GroupCode { get; set; }

    public decimal? S1Point { get; set; }

    public decimal? S2Point { get; set; }

    public decimal? S3Point { get; set; }

    public decimal? S4Point { get; set; }

    public decimal? S5Point { get; set; }

    public decimal? TotalPoint { get; set; }

    public string? S1EvalGrade { get; set; }

    public string? S2EvalGrade { get; set; }

    public string? S3EvalGrade { get; set; }

    public string? EvalGrade { get; set; }

    public string? S1Comment { get; set; }

    public string? S2Comment { get; set; }

    public string? S5Comment { get; set; }

    public short? S1FactorPoint { get; set; }

    public short? S2FactorPoint { get; set; }

    public short? S3FactorPoint { get; set; }

    public short? LateCnt { get; set; }

    public short? WarningCnt { get; set; }

    public short? WarningMinutes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }

    public decimal? GrpEvalPoint { get; set; }
}

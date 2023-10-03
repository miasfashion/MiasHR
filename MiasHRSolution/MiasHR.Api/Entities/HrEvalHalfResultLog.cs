using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalHalfResultLog
{
    public int Seq { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogUserId { get; set; }

    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string? Position { get; set; }

    public short? PositionYrs { get; set; }

    public byte[]? BPayrollMonthly { get; set; }

    public decimal? BOth1Monthly { get; set; }

    public decimal? BOth2Monthly { get; set; }

    public decimal? BOth3Monthly { get; set; }

    public decimal? AvgRate { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupGrade { get; set; }

    public decimal? GroupPer { get; set; }

    public string? EmplGrade { get; set; }

    public decimal? EmplPer { get; set; }

    public decimal? ResultRate { get; set; }

    public decimal? AdjRate { get; set; }

    public byte[]? Bonus { get; set; }

    public decimal? Oth1 { get; set; }

    public decimal? Oth2 { get; set; }

    public decimal? Oth3 { get; set; }

    public byte[]? BonusTotal { get; set; }

    public decimal? BonusRate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

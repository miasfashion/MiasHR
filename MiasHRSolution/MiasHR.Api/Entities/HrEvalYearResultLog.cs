using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalYearResultLog
{
    public int Seq { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogUserId { get; set; }

    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string? Position { get; set; }

    public short? PositionYrs { get; set; }

    public string? GroupCode { get; set; }

    public byte[]? BPayrollAnnual { get; set; }

    public decimal? BOth1Annual { get; set; }

    public decimal? BOth2Annual { get; set; }

    public decimal? BOth3Annual { get; set; }

    public decimal? AvgRate { get; set; }

    public string? T1Grade { get; set; }

    public decimal? T1Per { get; set; }

    public string? T2Grade { get; set; }

    public decimal? T2Per { get; set; }

    public decimal? ResultRate { get; set; }

    public decimal? AdjRate { get; set; }

    public decimal? PromoRate { get; set; }

    public byte[]? PayrollIncrease { get; set; }

    public decimal? Oth1Increase { get; set; }

    public decimal? Oth2Increase { get; set; }

    public decimal? Oth3Increase { get; set; }

    public byte[]? IncreaseTotal { get; set; }

    public decimal? IncreaseRate { get; set; }

    public byte[]? APayrollAnnual { get; set; }

    public decimal? AOth1Annual { get; set; }

    public decimal? AOth2Annual { get; set; }

    public decimal? AOth3Annual { get; set; }

    public string? Oth1Name { get; set; }

    public string? Oth1StartMonth { get; set; }

    public string? Oth2Name { get; set; }

    public string? Oth2StartMonth { get; set; }

    public string? Oth3Name { get; set; }

    public string? Oth3StartMonth { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

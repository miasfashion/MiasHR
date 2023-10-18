using System;
using System.Collections.Generic;

namespace MiasHR.Api;

public partial class HrPayroll
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public short? Status { get; set; }

    public string? PayrollStartDate { get; set; }

    public byte[]? PayrollAnnual { get; set; }

    public byte[]? PayrollMonthly { get; set; }

    public byte[]? PayrollSemimonthly { get; set; }

    public byte[]? PayrollBiweekly { get; set; }

    public byte[]? PayrollHourly { get; set; }

    public decimal? PayrollIncreasePer { get; set; }

    public string? Oth1PayrollName { get; set; }

    public decimal? Oth1PayrollMonthly { get; set; }

    public string? Oth1StartMonth { get; set; }

    public decimal? Oth1IncreasePer { get; set; }

    public string? Oth2PayrollName { get; set; }

    public decimal? Oth2PayrollMonthly { get; set; }

    public string? Oth2StartMonth { get; set; }

    public decimal? Oth2IncreasePer { get; set; }

    public string? Oth3PayrollName { get; set; }

    public decimal? Oth3PayrollMonthly { get; set; }

    public string? Oth3StartMonth { get; set; }

    public decimal? Oth3IncreasePer { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

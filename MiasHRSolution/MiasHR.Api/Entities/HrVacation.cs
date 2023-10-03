using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrVacation
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public string Yyyy { get; set; } = null!;

    public string VType { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string? StartDate { get; set; }

    public decimal? Days { get; set; }

    public decimal? PreMonthLeftDays { get; set; }

    public decimal? MonthUsedDays { get; set; }

    public decimal? MonthAdjDays { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalSelfSummary
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public decimal? SelfPoint { get; set; }

    public string? SelfGrade { get; set; }

    public string? SelfComment { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

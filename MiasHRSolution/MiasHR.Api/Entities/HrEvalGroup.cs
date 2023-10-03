using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalGroup
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public string? GroupDesc { get; set; }

    public short? GroupSortNo { get; set; }

    public string? Div { get; set; }

    public short? DivSortNo { get; set; }

    public string? Step1Appraiser { get; set; }

    public string? Step2Appraiser { get; set; }

    public string? Step3Appraiser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

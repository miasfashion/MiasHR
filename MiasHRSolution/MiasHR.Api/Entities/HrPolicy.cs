using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrPolicy
{
    public int Seq { get; set; }

    public string? OrgCode { get; set; }

    public int? Status { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? ConsentYn { get; set; }

    public string? ConsentContent { get; set; }

    public int? SortNo { get; set; }

    public int? Hit { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

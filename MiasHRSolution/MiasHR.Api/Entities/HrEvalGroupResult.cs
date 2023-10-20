using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalGroupResult
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public string? Grade { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

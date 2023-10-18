using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalGroupDept
{
    public string OrgCode { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string DeptCode { get; set; } = null!;

    public string? DeptName { get; set; }

    public short? DeptSortNo { get; set; }

    public string? DivCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

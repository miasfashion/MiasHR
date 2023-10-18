using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbDepartment
{
    public string DeptCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public string? DivCode { get; set; }

    public int? SortNo { get; set; }

    public int Status { get; set; }

    public string? AdminYn { get; set; }

    public string? ManageEmplCode { get; set; }

    public int? DeptLevel { get; set; }

    public string? UpperDeptCode { get; set; }

    public string? StoreYn { get; set; }

    public string? QbKey { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

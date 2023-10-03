using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeePlan
{
    public string Yyyymm { get; set; } = null!;

    public string DeptCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public int? PlanCnt { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeeCareer
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? JobDesc { get; set; }

    public string? LeaveReason { get; set; }

    public string? FromYyyymm { get; set; }

    public string? ToYyyymm { get; set; }

    public decimal? Salary { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

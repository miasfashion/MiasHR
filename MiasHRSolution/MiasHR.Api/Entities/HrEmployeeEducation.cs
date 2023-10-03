using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeeEducation
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string? EduType { get; set; }

    public string? EduName { get; set; }

    public string? Address { get; set; }

    public string? EduContent { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public string? FinishDegree { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

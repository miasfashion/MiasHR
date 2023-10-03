using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeeRp
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string? Date { get; set; }

    public string? RpType { get; set; }

    public string? RpTitle { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

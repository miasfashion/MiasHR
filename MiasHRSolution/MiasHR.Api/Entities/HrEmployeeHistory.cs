using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEmployeeHistory
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string? Date { get; set; }

    public string? HistType { get; set; }

    public string? OldCode { get; set; }

    public string? OldDesc { get; set; }

    public string? NewCode { get; set; }

    public string? NewDesc { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

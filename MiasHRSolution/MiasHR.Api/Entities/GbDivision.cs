using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbDivision
{
    public string DivCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string DivName { get; set; } = null!;

    public int? SortNo { get; set; }

    public int? TreeSortNo { get; set; }

    public int Status { get; set; }

    public string? AdminYn { get; set; }

    public int? DivLevel { get; set; }

    public string? UpperDivCode { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

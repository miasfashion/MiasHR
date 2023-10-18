using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaGeneralCode
{
    public string Class { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public int? SortNo { get; set; }

    public int Status { get; set; }

    public string? Value1 { get; set; }

    public string? Value2 { get; set; }

    public string? Value3 { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

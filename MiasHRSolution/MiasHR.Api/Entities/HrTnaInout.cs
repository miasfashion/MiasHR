using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaInout
{
    public string OrgCode { get; set; } = null!;

    public string Date { get; set; } = null!;

    public int Seq { get; set; }

    public int Status { get; set; }

    public string EmplCode { get; set; } = null!;

    public string? OutTime { get; set; }

    public string? InTime { get; set; }

    public string? AutoYn { get; set; }

    public string? AutoCode { get; set; }

    public string? GasCardYn { get; set; }

    public string? GasCardCode { get; set; }

    public decimal? GasCardAmt { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrPayrollBonu
{
    public string OrgCode { get; set; } = null!;

    public string EmplCode { get; set; } = null!;

    public int Seq { get; set; }

    public short? Status { get; set; }

    public string? PayDate { get; set; }

    public string? Year { get; set; }

    public string? Term { get; set; }

    public byte[]? Bonus { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

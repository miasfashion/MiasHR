using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class VwOpMpsmaster
{
    public Guid MpsMasterSid { get; set; }

    public int MpsMasterId { get; set; }

    public string MpsWono { get; set; } = null!;

    public decimal? MpsYardPcs { get; set; }

    public string? MpsSeason { get; set; }

    public string? MpsSeasonyear { get; set; }

    public string? MpsContact { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? MpsStyleId { get; set; }

    public string? MpsStyle { get; set; }

    public string? MpsStyleDesc { get; set; }

    public int? MpsTotalOrderQty { get; set; }

    public string CustCode { get; set; } = null!;

    public string? VendCode { get; set; }

    public string? OrgCode { get; set; }
}

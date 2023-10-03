using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbCustomer
{
    public string CustCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public int? MpsCustId { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? UserCode { get; set; }
}

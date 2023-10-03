using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbVendor
{
    public string VendCode { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string VendName { get; set; } = null!;

    public int? MpsVendId { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? UserCode { get; set; }
}

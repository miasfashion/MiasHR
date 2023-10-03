using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTransaction
{
    public string TransType { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string? Description { get; set; }

    public int? CodeLen { get; set; }

    public int? LastNo { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

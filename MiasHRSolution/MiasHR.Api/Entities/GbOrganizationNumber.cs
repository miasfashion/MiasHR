using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbOrganizationNumber
{
    public string OrgCode { get; set; } = null!;

    public int Seq { get; set; }

    public string? Class { get; set; }

    public string? No { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? StartDate { get; set; }

    public string? ExpireDate { get; set; }

    public string? Remark { get; set; }

    public DateTime? NoticeSendDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

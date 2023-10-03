using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class GbOrganization
{
    public string OrgCode { get; set; } = null!;

    public string OrgName { get; set; } = null!;

    public string? ShortName { get; set; }

    public int? Seq { get; set; }

    public int Status { get; set; }

    public string? OrgType { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Homepage { get; set; }

    public string? Remark { get; set; }

    public string? TempOrgYn { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

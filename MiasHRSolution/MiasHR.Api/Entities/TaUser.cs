using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaUser
{
    public string UserCode { get; set; } = null!;

    public string? UserName { get; set; }

    public string Password { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? EmplCode { get; set; }

    public string? OrgCode { get; set; }

    public string? CustCode { get; set; }

    public string? VendCode { get; set; }

    public string? MpsId { get; set; }

    public int Status { get; set; }

    public string? PriorityLevel { get; set; }

    public string? OtherOrgCode { get; set; }

    public string? PayrollOrgOnly { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

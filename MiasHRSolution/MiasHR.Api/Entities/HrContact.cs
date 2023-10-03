using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrContact
{
    public string OtherCode { get; set; } = null!;

    public string? OtherType { get; set; }

    public int Status { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Tel { get; set; }

    public string? Tel2 { get; set; }

    public string? Cell { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

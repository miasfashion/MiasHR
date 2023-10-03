using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfMpsEvent
{
    public int EventId { get; set; }

    public string? OrgCode { get; set; }

    public string? CustCode { get; set; }

    public string? VendCode { get; set; }

    public string? EventDesc { get; set; }

    public DateTime? EventDate { get; set; }

    public DateTime? ConfirmDate { get; set; }
}

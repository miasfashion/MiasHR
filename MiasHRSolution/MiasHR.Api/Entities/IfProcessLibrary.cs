using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfProcessLibrary
{
    public Guid ProcessLibSid { get; set; }

    public string OrgCode { get; set; } = null!;

    public string VendCode { get; set; } = null!;

    public int ProcessCheck { get; set; }

    public string ProcessName { get; set; } = null!;

    public int ProcessUnit { get; set; }

    public int? Seq { get; set; }

    public int Date1Check { get; set; }

    public string? Date1Name { get; set; }

    public int Date2Check { get; set; }

    public string? Date2Name { get; set; }

    public int Qty1Check { get; set; }

    public string? Qty1UnitName { get; set; }

    public int Percentage1Check { get; set; }

    public string? Percentage1Name { get; set; }

    public int String1Check { get; set; }

    public string? String1Name { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}

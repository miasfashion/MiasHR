using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class VEmployee
{
    public string EmplCode { get; set; } = null!;

    public string? Org { get; set; }

    public string? EmplName { get; set; }

    public string? ComTel { get; set; }

    public string? ComTelExt { get; set; }

    public string? ComEmail { get; set; }

    public string? EmplType { get; set; }

    public string? DivName { get; set; }

    public string? DeptName { get; set; }

    public string? DeptName2 { get; set; }

    public string? ActiveYn { get; set; }
}

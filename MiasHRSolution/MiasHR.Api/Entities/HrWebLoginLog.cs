using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiasHR.Api.Entities;

public partial class HrWebLoginLog
{
    public string? EmplCode { get; set; }

    public DateTime? LoginDate { get; set; }

    public string? Ip { get; set; }

    public string? AcceptYn { get; set; }

    public string? Remark { get; set; }
}

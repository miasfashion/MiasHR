using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfProcess
{
    public Guid ProcessSid { get; set; }

    public Guid MpsMasterSid { get; set; }

    public Guid ProcessLibSid { get; set; }

    public int? Seq { get; set; }

    public DateTime? Date1 { get; set; }

    public DateTime? Date2 { get; set; }

    public int? TargetQty { get; set; }

    public decimal? TargetLength { get; set; }

    public string? Remark { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? LocalModifiedDate { get; set; }

    public string? UserCode { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string? ConfirmUserCode { get; set; }
}

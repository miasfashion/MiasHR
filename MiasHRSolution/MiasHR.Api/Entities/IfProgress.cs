using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfProgress
{
    public Guid ProgressSid { get; set; }

    public Guid ProcessSid { get; set; }

    public string? MpsCustPono { get; set; }

    public int? MpsStyleId { get; set; }

    public string? MpsStyle { get; set; }

    public int? MpsColorId { get; set; }

    public string? MpsColorIp { get; set; }

    public int? MpsGraphicStyleId { get; set; }

    public DateTime? MpsIndcDate { get; set; }

    public DateTime BaseDate { get; set; }

    public decimal? Qty1 { get; set; }

    public decimal? Percentage1 { get; set; }

    public string? String1 { get; set; }

    public string? Remark { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime? LocalModifiedDate { get; set; }

    public string? UserCode { get; set; }

    public string? ConfirmComment { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string? ConfirmUserCode { get; set; }
}

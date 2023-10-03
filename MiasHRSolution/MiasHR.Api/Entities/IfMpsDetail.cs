using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class IfMpsDetail
{
    public Guid MpsDetailSid { get; set; }

    public Guid MpsMasterSid { get; set; }

    public int? MpsMasterId { get; set; }

    public int MpsWoId { get; set; }

    public string? MpsCustPono { get; set; }

    public int? MpsStyleId { get; set; }

    public string? MpsStyle { get; set; }

    public string? MpsStyleDesc { get; set; }

    public int? MpsColorId { get; set; }

    public string? MpsColorIp { get; set; }

    public string? MpsColorActual { get; set; }

    public int? MpsGraphicStyleId { get; set; }

    public string? MpsGraphicStyle { get; set; }

    public int MpsOrderQty { get; set; }

    public DateTime? MpsIndcDate { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}

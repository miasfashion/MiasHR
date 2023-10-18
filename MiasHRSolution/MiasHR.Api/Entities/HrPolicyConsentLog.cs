using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrPolicyConsentLog
{
    public int Seq { get; set; }

    public int? PolicySeq { get; set; }

    public string? EmplCode { get; set; }

    public string? ConsentYn { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

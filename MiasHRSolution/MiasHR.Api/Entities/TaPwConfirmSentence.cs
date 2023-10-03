using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaPwConfirmSentence
{
    public string Type { get; set; } = null!;

    public byte[]? ConfirmSentence { get; set; }

    public byte[]? ConfirmKey { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

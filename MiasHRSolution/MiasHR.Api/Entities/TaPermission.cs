using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaPermission
{
    public string SysCode { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public string PgmCode { get; set; } = null!;

    public string? OpenYn { get; set; }

    public string? NewYn { get; set; }

    public string? CopyYn { get; set; }

    public string? InquiryYn { get; set; }

    public string? DetailYn { get; set; }

    public string? SearchYn { get; set; }

    public string? ClearYn { get; set; }

    public string? SaveYn { get; set; }

    public string? DeleteYn { get; set; }

    public string? UploadYn { get; set; }

    public string? ExcelYn { get; set; }

    public string? PrintYn { get; set; }

    public string? HelpYn { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class TaProgram
{
    public string SysCode { get; set; } = null!;

    public string PgmCode { get; set; } = null!;

    public string? PgmName { get; set; }

    public int Status { get; set; }

    public string? PgmModule { get; set; }

    public int? SortNo { get; set; }

    public string? UpperPgmCode { get; set; }

    public string? PgmType { get; set; }

    public string? PgmLevel { get; set; }

    public string? FormId { get; set; }

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

    public string? Remark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

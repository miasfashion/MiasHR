using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrWebRequest
{
    public int Seq { get; set; }

    public int Status { get; set; }

    public string EmplCode { get; set; } = null!;

    public string? ReqDate { get; set; }

    public string? ReqType { get; set; }

    public string? ReqSubType { get; set; }

    public string? PeriodFrom { get; set; }

    public string? PeriodTo { get; set; }

    public decimal? DaysCnt { get; set; }

    public int? HoursCnt { get; set; }

    public TimeSpan? StartTime { get; set; }

    public string? ReqTitle { get; set; }

    public string? ReqContent { get; set; }

    public string? ReqIp { get; set; }

    public string? Approve1stYn { get; set; }

    public string? Approve1stUser { get; set; }

    public DateTime? Approve1stDate { get; set; }

    public string? Approve2ndYn { get; set; }

    public string? Approve2ndUser { get; set; }

    public DateTime? Approve2ndDate { get; set; }

    public string? MhrsUpdateYn { get; set; }

    public string? MhrsUpdateUser { get; set; }

    public string? RejectReason { get; set; }

    public string? RejectUser { get; set; }

    public DateTime? RejectDate { get; set; }

    public string? SickdayYn { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

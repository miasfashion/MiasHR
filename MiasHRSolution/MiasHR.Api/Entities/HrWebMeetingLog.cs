using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrWebMeetingLog
{
    public int Seq { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogUser { get; set; }

    public string? LogType { get; set; }

    public int ReqId { get; set; }

    public int? Status { get; set; }

    public string? EmplCode { get; set; }

    public string? DeptName { get; set; }

    public string? ReqDate { get; set; }

    public string? ReqMeetingDate { get; set; }

    public TimeSpan? ReqMeetingTime { get; set; }

    public string? ReqContent { get; set; }

    public string? ReqTo { get; set; }

    public string? AltMeetingDate { get; set; }

    public TimeSpan? AltMeetingTime { get; set; }

    public string? InCharge { get; set; }

    public string? MeetingDate { get; set; }

    public TimeSpan? MeetingTime { get; set; }

    public string? MeetingContent { get; set; }

    public string? MeetingAttendance { get; set; }

    public DateTime? CloseDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

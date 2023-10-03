using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrWebUser
{
    public string EmplCode { get; set; } = null!;

    public string? Email { get; set; }

    public string? Pw { get; set; }

    public string? NickName { get; set; }

    public int Status { get; set; }

    public int? LoginCnt { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }

    public string? Temp { get; set; }

    public int? MmsLevel { get; set; }
}

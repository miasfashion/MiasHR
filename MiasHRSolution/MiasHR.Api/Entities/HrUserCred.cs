using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrUserCred
{
    public string EmplCode { get; set; }

    public int Status { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

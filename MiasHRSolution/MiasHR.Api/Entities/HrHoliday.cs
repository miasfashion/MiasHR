using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrHoliday
{
    public string Date { get; set; } = null!;

    public string? Description { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

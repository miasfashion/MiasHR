using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrParkingLot
{
    public string LotGroup { get; set; } = null!;

    public string LotCode { get; set; } = null!;

    public int Status { get; set; }

    public string? ReserveCode { get; set; }

    public string? OrgCode { get; set; }

    public string? EmplCode { get; set; }

    public string? Remark { get; set; }

    public string? LotImage { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

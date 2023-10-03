using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrTnaBadge
{
    public int Seq { get; set; }

    public string? GroupCode { get; set; }

    public string? Date { get; set; }

    public string? PersonId { get; set; }

    public string? PersonName { get; set; }

    public string? CardNo { get; set; }

    public string? Inout { get; set; }

    public string? Time { get; set; }

    public string? CompanyCode { get; set; }

    public string? DepartCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}

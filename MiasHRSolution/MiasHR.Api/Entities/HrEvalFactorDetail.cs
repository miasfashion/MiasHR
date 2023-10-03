using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrEvalFactorDetail
{
    public string Factor { get; set; } = null!;

    public string FactorGrade { get; set; } = null!;

    public string? Description { get; set; }

    public short? Point { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

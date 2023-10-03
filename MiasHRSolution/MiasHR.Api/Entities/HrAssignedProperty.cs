using System;
using System.Collections.Generic;

namespace MiasHR.Api.Entities;

public partial class HrAssignedProperty
{
    public int Seq { get; set; }

    public string? EmplCode { get; set; }

    public string? OtherName { get; set; }

    public int? Status { get; set; }

    public string? Class { get; set; }

    public string? ClassSn { get; set; }

    public string? PropertyType { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? Specification { get; set; }

    public string? ProductSn { get; set; }

    public string? Purpose { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUser { get; set; }
}

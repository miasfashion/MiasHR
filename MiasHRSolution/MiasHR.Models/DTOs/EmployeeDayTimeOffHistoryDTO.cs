using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiasHR.Models.DTOs
{
    public class EmployeeDayTimeOffHistoryDTO
    {
        public int seq { get; }

        public string? yyyy { get; }

        public string? v_type_desc { get; }

        public decimal? carry_over_days { get; }

        public decimal? basic_days { get; }

        public decimal? hold_days { get; }

        public decimal? adjust_days { get; }

        public decimal? used_days { get; }

        public string? remark { get; }

        public string? v_type { get; }

    }
}
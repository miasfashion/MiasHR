﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasHR.Models.DTOs
{
    public class ADHistoryDTO
    {
        public int Seq { get; set; }
        public string Date { get; set; }
        public string Rp_Type { get; set; }
        public string Rp_Type_Desc { get; set; }
        public string Rp_Title { get; set; }
        public string Remark { get; set; }
    }
}

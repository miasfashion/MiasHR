using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasHR.Models.DTOs
{
    public class FactorEvalDTO
    {
        public string factor { get; set; }
        public string factor_desc { get; set; }
        public string line_display { get; set; }
        public string factor_grade { get; set; }
        public string grade_desc { get;set; }
        public string f_checked { get; set; }
        public string comment { get; set; }
        public string group_desc { get; set; }
        public string appraiser1 { get; set; }
        public string appraiser2 { get; set; }
        public string open_yn { get; set; }
    }
}

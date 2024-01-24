using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasHR.Models.DTOs
{
    public class UpdateMessageDTO
    {
        public string msg { get; set; }
        public string com_email { get; set; }
        public string empl_code { get; set; }
    }
}
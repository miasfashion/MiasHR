namespace MiasHR.Models.DTOs
{
    public class TransferHistoryDTO
    {
        public int Seq { get; set; }
        public string Date {  get; set; }
        public string Hist_Type { get; set; }
        public string Hist_Type_Desc { get; set; }
        public string Old_Desc { get; set;}
        public string New_Desc { get; set;}
        public string Remark { get; set;}
    }
}

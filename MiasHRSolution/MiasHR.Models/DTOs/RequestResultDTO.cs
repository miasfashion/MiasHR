namespace MiasHR.Models.DTOs
{
    public class RequestResultDTO
    {
        public string status { get; set; }
        public Dictionary<string, dynamic> data { get; set; }

        public RequestResultDTO(string status, Dictionary<string, dynamic> dict)
        {
            this.status = status;
            data = dict;
        }
    }
}
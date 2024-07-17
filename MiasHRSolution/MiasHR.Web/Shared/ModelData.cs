namespace MiasHR.Web.Shared
{
    public class ModelData
    {
        public string? Category { get; set; }
        public double Value { get; set; }
        public string? Color { get; set; }
        public string? Group { get; set; }
        public bool ShouldShowInLegend { get; set; } = true;
    }
}
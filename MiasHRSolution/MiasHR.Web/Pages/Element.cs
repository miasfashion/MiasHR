using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MudBlazor.Examples.Data.Models
{
    public class Element
    {
        public string Group { get; set; } = "Hey";
        public int Position { get; set; } = 1;
        public string Name { get; set; } = "Hey";
        public int Number { get; set; } = 2;

        [JsonPropertyName("small")]
        public string Sign { get; set; }
        public double Molar { get; set; }
        public IList<int> Electrons { get; set; }

        public override string ToString()
        {
            return $"{Sign} - {Name}";
        }
    }
}
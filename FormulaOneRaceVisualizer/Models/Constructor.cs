using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Constructor
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("nationality")]
        public string Nationality { get; set; } = string.Empty;
    }
}

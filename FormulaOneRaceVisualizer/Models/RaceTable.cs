using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class RaceTable
    {
        [JsonProperty("season")]
        public string Season { get; set; } = string.Empty;

        [JsonProperty("round")]
        public string Round { get; set; } = string.Empty;

        [JsonProperty("Races")]
        public List<Race>? Races { get; set; }
    }
}

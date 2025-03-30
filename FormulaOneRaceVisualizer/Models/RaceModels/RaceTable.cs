using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceTable
    {
        [JsonProperty("season")]
        public string Season { get; set; } = string.Empty;

        [JsonProperty("Races")]
        public List<Race> Races { get; set; } = new List<Race>();
    }
}

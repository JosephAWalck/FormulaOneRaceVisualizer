using FormulaOneRaceVisualizer.Models.RaceModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class RaceByLaps
    {
        [JsonProperty("season")]
        public string Season { get; set; } = string.Empty;

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; } = new Circuit();

        [JsonProperty("Laps")]
        public List<Lap> Laps { get; set; } = new List<Lap>();
    }
}

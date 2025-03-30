using FormulaOneRaceVisualizer.Models.LapModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class Race
    {
        [JsonProperty("round")]
        public string Round { get; set; } = string.Empty;

        [JsonProperty("raceName")]
        public string RaceName { get; set; } = string.Empty;

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; } = new Circuit();

        [JsonProperty("date")]
        public string Date { get; set; } = string.Empty;

        [JsonProperty("time")]
        public string Time { get; set; } = string.Empty;

        [JsonProperty("Results")]
        public List<RaceResult> Results { get; set; } = [];

        public List<Lap> Laps { get; set; } = [];
    }
}

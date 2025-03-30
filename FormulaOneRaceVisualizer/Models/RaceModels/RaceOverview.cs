using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceOverview
    {
        [JsonProperty("round")]
        public string Round { get; set; } = string.Empty;

        [JsonProperty("raceName")]
        public string RaceName { get; set; } = string.Empty;

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; } = new Circuit();

    }
}

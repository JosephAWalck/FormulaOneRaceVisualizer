using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Race
    {
        [JsonProperty("raceName")]
        public string RaceName { get; set; } = string.Empty;

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; } = new Circuit();

        [JsonProperty("date")]
        public string Date { get; set; } = string.Empty;

        [JsonProperty("time")]
        public string Time { get; set; } = string.Empty;

        [JsonProperty("Results")]
        public List<Result> Results { get; set; } = [];
    }
}

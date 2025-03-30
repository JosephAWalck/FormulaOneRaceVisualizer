using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class Race
    {
        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("raceName")]
        public string RaceName { get; set; } = string.Empty;

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; } = new Circuit();

        // insert schedule data here
        
    }
}

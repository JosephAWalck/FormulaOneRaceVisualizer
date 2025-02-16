using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class Timing
    {
        [JsonProperty("driverId")]
        public string DriverId { get; set; } = string.Empty;

        [JsonProperty("position")]
        public string Position { get; set; } = string.Empty;

        [JsonProperty("time")]
        public string Time { get; set; } = string.Empty;
    }
}

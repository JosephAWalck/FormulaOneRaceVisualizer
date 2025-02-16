using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class Lap
    {
        [JsonProperty("number")]
        public string Number { get; set; } = string.Empty;

        [JsonProperty("Timings")]
        public List<Timing> Timings { get; set; } = new List<Timing>();
    }
}

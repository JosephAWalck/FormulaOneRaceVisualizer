using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceResult
    {
        [JsonProperty("position")]
        public string Position { get; set; } = string.Empty;

        [JsonProperty("Driver")]
        public Driver Driver { get; set; } = new Driver();

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; } = new Constructor();
    }
}

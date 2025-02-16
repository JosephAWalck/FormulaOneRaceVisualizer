using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Result
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; }

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; }
    }
}

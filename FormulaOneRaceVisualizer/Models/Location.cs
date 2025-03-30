using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Location
    {
        [JsonProperty("lat")]
        public float latitude { get; set; }

        [JsonProperty("long")]
        public float longitude { get; set; }

        [JsonProperty("locality")]
        public string locality { get; set; } = string.Empty;

        [JsonProperty("country")]
        public string country { get; set; } = string.Empty;
    }
}

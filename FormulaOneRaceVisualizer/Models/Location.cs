using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Location
    {
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("long")]
        public float Longitude { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; } = string.Empty;

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;
    }
}

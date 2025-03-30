using Newtonsoft.Json;
using System.Security;

namespace FormulaOneRaceVisualizer.Models
{
    public class Circuit
    {
        [JsonProperty("circuitId")]
        public string CircuitId { get; set; } = string.Empty;

        [JsonProperty("circuitName")]
        public string CircuitName { get; set; } = string.Empty;

        [JsonProperty("Location")]
        public Location Location { get; set; } = new Location();
    }
}

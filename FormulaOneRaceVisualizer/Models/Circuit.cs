using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Circuit
    {
        [JsonProperty("circuitName")]
        public string CircuitName {  get; set; } = string.Empty;
    }
}

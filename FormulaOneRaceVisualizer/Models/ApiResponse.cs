using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class ApiResponse
    {
        [JsonProperty("MRData")]
        public MRData MRData { get; set; } = new MRData();
    }
}

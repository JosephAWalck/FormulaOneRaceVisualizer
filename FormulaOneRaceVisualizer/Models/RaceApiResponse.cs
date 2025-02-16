using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class RaceApiResponse
    {
        [JsonProperty("MRData")]
        public MRData MRData { get; set; } = new MRData();
    }
}

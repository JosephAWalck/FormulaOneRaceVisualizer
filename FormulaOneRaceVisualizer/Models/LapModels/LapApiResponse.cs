using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class LapApiResponse
    {
        [JsonProperty("MRData")]
        public LapMRData MRData { get; set; } = new LapMRData();
    }
}

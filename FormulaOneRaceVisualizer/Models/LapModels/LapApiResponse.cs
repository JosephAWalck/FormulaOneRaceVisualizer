using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class LapApiResponse
    {
        [JsonProperty("MRData")]
        public MRData MRData { get; set; } = new MRData();
    }
}

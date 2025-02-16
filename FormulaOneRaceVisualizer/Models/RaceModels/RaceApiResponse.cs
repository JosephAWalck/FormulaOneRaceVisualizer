using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceApiResponse
    {
        [JsonProperty("MRData")]
        public MRData MRData { get; set; } = new MRData();
    }
}

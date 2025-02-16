using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceApiResponse
    {
        [JsonProperty("MRData")]
        public RaceMRData MRData { get; set; } = new RaceMRData();
    }
}

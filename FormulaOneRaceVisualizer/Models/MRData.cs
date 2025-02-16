using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class MRData
    {
        [JsonProperty("RaceTable")]
        public RaceTable RaceTable { get; set; } = new RaceTable();
    }
}

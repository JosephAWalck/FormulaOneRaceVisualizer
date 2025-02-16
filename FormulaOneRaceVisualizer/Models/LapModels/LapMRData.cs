using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class LapMRData
    {
        [JsonProperty("RaceTable")]
        public LapTable LapTable { get; set; } = new LapTable();
    }
}

using FormulaOneRaceVisualizer.Models.LapModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceMRData
    {
        [JsonProperty("RaceTable")]
        public RaceTable RaceTable { get; set; } = new RaceTable();
    }
}

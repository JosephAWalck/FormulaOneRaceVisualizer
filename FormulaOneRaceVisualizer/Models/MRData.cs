using FormulaOneRaceVisualizer.Models.LapModels;
using FormulaOneRaceVisualizer.Models.SeasonModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class MRData
    {
        [JsonProperty("RaceTable")]
        public RaceTable RaceTable { get; set; } = new RaceTable();

        [JsonProperty("SeasonTable")]
        public SeasonTable SeasonTable { get; set; } = new SeasonTable();
    }
}

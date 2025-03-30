using FormulaOneRaceVisualizer.Models.RaceModels;
using FormulaOneRaceVisualizer.Models.SeasonModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class MRData
    {
        [JsonProperty("SeasonTable")]
        public SeasonTable SeasonTable { get; set; } = new SeasonTable();

        [JsonProperty("RaceTable")]
        public RaceTable RacesTable { get; set; } = new RaceTable();
    }
}

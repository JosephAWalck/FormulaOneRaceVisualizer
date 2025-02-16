using FormulaOneRaceVisualizer.Models.RaceModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.LapModels
{
    public class LapTable
    {
        [JsonProperty("season")]
        public string Season { get; set; } = string.Empty;

        [JsonProperty("round")]
        public string Round { get; set; } = string.Empty;

        [JsonProperty("Races")]
        public List<Race> Race { get; set; } = new List<Race>();
    }
}

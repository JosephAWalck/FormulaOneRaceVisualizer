using FormulaOneRaceVisualizer.Models.DriverModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class StandingsTable
    {
        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("StandingsLists")]
        public List<StandingsLists> StandingsLists { get; set; } = new List<StandingsLists>();

    }
}

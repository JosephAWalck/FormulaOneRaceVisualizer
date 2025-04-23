using FormulaOneRaceVisualizer.Models.ConstructorModels;
using FormulaOneRaceVisualizer.Models.DriverModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class StandingsLists
    {
        [JsonProperty("season")]
        public int season {  get; set; }

        [JsonProperty("round")]
        public int round { get; set; }

        [JsonProperty("DriverStandings")]
        public List<DriverStanding> DriverStandings { get; set; } = new List<DriverStanding>();

        [JsonProperty("ConstructorStandings")]
        public List<ConstructorStanding> ConstructorStandings { get; set; } = new List<ConstructorStanding>();
    }
}

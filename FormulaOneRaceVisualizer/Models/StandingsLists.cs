using FormulaOneRaceVisualizer.Models.DriverModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class StandingsLists
    {
        [JsonProperty("DriverStandings")]
        public List<DriverStanding> DriverStandings { get; set; } = [];
    }
}

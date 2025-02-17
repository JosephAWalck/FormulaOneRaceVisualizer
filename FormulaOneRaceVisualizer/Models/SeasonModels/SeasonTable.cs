using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.SeasonModels
{
    public class SeasonTable
    {
        [JsonProperty("Seasons")]
        public List<Season> Seasons { get; set; } = new List<Season>();
    }
}

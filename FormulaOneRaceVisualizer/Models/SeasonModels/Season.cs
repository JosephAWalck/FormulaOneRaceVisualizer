using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.SeasonModels
{
    public class Season
    {
        [JsonProperty("season")]
        public string SeasonName { get; set; } = string.Empty;
    }
}

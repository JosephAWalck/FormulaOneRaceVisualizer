using FormulaOneRaceVisualizer.Models.ConstructorModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class GridResult
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; } = new Driver();

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; } = new Constructor();

        [JsonProperty("grid")]
        public int StartingPosition { get; set; }

        [JsonProperty("laps")]
        public int Laps { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        [JsonProperty("Time")]
        public RaceTime Time { get; set; } = new RaceTime();

        // TODO: fastest lap
    }
}

using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.ConstructorModels
{
    public class ConstructorStanding
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; } = new Constructor();
    }
}

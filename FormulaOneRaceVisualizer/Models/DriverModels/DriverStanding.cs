using FormulaOneRaceVisualizer.Models.ConstructorModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.DriverModels
{
    public class DriverStanding
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; } = new Driver();

        [JsonProperty("Constructors")]
        public List<Constructor> Constructors { get; set; } = new List<Constructor>();

    }
}

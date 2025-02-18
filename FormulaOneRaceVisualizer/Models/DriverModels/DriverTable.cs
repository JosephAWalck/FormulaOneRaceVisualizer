using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.DriverModels
{
    public class DriverTable
    {
        [JsonProperty("Drivers")]
        public List<Driver> Drivers { get; set; } = new List<Driver>();
    }
}

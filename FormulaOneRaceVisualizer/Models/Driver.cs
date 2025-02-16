using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models
{
    public class Driver
    {
        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;

        [JsonProperty("givenName")]
        public string GivenName { get; set; } = string.Empty;

        [JsonProperty("familyName")]
        public string FamilyName { get; set; } = string.Empty;

        [JsonProperty("nationality")]
        public string Nationality { get; set; } = string.Empty;
        
    }
}

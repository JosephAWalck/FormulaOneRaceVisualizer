using FormulaOneRaceVisualizer.Models.RaceModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.DTOs
{
    public class RaceDTO
    {
        public string RaceName { get; set; } = string.Empty;

        public Circuit Circuit { get; set; } = new Circuit();

        public string Date { get; set; } = string.Empty;

        public string Time { get; set; } = string.Empty;

        public List<RaceResult> Results { get; set; } = new List<RaceResult>();
    }
}

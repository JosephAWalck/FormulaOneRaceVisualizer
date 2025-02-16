using FormulaOneRaceVisualizer.Models.LapModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Models.DTOs
{
    public class LapDTO
    {
        public string RaceName { get; set; } = string.Empty;
        
        public Circuit Circuit { get; set; } = new Circuit();
        
        public string Date { get; set; } = string.Empty;

        public string Time { get; set; } = string.Empty;

        public List<Lap> Laps { get; set; } = new List<Lap>();
    }
}

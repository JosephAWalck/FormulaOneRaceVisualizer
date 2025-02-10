namespace FormulaOneRaceVisualizer.Models
{
    public class RaceResult
    {
        public string RaceName { get; set; } = string.Empty;
        public Circuit Circuit { get; set; } = new Circuit(); 
        public List<DriverResult> Results { get; set; } = [];
    }
}

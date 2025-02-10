namespace FormulaOneRaceVisualizer.Models
{
    public class DriverResult
    {
        public Driver Driver { get; set; } = new Driver();
        public Constructor Constructor { get; set; } = new Constructor();
        public string Position { get; set; } = string.Empty;
    }
}

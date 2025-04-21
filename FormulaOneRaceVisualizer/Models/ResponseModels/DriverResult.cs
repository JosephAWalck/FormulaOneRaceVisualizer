namespace FormulaOneRaceVisualizer.Models.ResponseModels
{
    public class DriverResult
    {
        public string GrandPrix { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string ConstructorName { get; set; } = string.Empty;
        public int Position { get; set; }
        public int Points { get; set; }
    }
}

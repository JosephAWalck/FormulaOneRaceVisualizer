namespace FormulaOneRaceVisualizer.Models.ResponseModels
{
    public class DriverStandingResponse
    {
        public int Position { get; set; }
        public string DriverName { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string ConstructorName { get; set; } = string.Empty;
        public int Points { get; set; }
    }
}

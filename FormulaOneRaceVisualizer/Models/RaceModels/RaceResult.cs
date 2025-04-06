namespace FormulaOneRaceVisualizer.Models.RaceModels
{
    public class RaceResult
    {
        public int Position { get; set; }
        public int Number { get; set; }
        public string Driver { get; set; } = string.Empty;
        public string Constructor { get; set; } = string.Empty;
        public int Laps { get; set; }
        public string Time { get; set; } = string.Empty;
        public int Points { get; set; }

    }
}

using FormulaOneRaceVisualizer.Models.RaceModels;

namespace FormulaOneRaceVisualizer.Models.ResponseModels
{
    public class RaceResultOverviewResponse
    {
        public List<RaceResultsOverview> RaceResultsOverview { get; set; } = new List<RaceResultsOverview>();
    }
}

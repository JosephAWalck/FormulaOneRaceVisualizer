using FormulaOneRaceVisualizer.Models;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IRaceService
    {
        Task<RaceResult> GetRaceResultsAsync(int season, int round);
    }
}

using FormulaOneRaceVisualizer.Models;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IRaceService
    {
        Task<RaceApiResponse> GetRaceResultsAsync(int season, int round);
    }
}

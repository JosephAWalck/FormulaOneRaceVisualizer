using FormulaOneRaceVisualizer.Models.DTOs;
using FormulaOneRaceVisualizer.Models.RaceModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IRaceService
    {
        Task<RaceDTO> GetRaceResultsAsync(int season, int round);
        Task<List<RaceOverview>> GetSeasonRaces(int season);
    }
}

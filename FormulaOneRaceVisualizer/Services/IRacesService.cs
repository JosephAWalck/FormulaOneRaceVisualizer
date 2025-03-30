using FormulaOneRaceVisualizer.Models.ResponseModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IRacesService
    {
        Task<RaceListResponse> GetRaceListForSeasonAsync(int seasonId);
        // Task<RacesOverviewForSeason> GetRacesOverviewForSeason(int seasonId);
        // Task<RaceResults> GetRaceResults(int seasonId, int round);
    }
}

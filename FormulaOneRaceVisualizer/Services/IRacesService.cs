using FormulaOneRaceVisualizer.Models.RaceModels;
using FormulaOneRaceVisualizer.Models.ResponseModels;
using FormulaOneRaceVisualizer.Models.SeasonModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IRacesService
    {
        Task<RaceListResponse> GetRaceListForSeasonAsync(int seasonId);
        Task<RaceResultOverviewResponse> GetRaceResultsOverviewAsync(int season);

        Task<RaceResultsResponse> GetRaceResultsAsync(int seasonId, int round);
    }
}

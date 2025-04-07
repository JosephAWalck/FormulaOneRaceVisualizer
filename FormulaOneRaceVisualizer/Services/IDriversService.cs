using FormulaOneRaceVisualizer.Models.ResponseModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IDriversService
    {
        Task<DriversStandingsResponse> GetDriversStandingsAsync(int seasonId);
    }
}

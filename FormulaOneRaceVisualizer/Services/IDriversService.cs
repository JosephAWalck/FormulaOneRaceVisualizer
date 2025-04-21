using FormulaOneRaceVisualizer.Models.ResponseModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IDriversService
    {
        Task<DriversStandingsResponse> GetDriversStandingsAsync(int seasonId);
        Task<DriverResultsResponse> GetDriverResultsDataAsync(int seasonId, string driverId);
    }
}

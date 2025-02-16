using FormulaOneRaceVisualizer.Models.LapModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface ILapService
    {
        Task<LapApiResponse> GetLapDataAsync(int season, int round, int lap);
    }
}

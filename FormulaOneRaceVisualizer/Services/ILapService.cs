using FormulaOneRaceVisualizer.Models.DTOs;

namespace FormulaOneRaceVisualizer.Services
{
    public interface ILapService
    {
        Task<LapDTO> GetLapDataAsync(int season, int round, int lap);
    }
}

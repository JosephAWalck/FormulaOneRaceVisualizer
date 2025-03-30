using FormulaOneRaceVisualizer.Models.ResponseModels;

namespace FormulaOneRaceVisualizer.Services
{
    public interface ISeasonService
    {
        Task<SeasonsResponse> GetSeasonsAsync();
    }
}

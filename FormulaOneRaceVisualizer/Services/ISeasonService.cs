using FormulaOneRaceVisualizer.Models.DTOs;

namespace FormulaOneRaceVisualizer.Services
{
    public interface ISeasonService
    {
        Task<SeasonDTO> GetSeasonsAsync();
    }
}

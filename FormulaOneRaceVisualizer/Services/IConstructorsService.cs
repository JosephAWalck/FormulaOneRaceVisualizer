using FormulaOneRaceVisualizer.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IConstructorsService
    {
        Task<ConstructorStandingsResponse> GetConstructorsStandingsAsync(int season);

        Task<ConstructorResultsResponse> GetConstructorsResultsAsync(int season, string constructorId);
    }
}

using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    public class ConstructorsController : Controller
    {
        private readonly IConstructorsService _constructorsService;

        public ConstructorsController(IConstructorsService constructorsService)
        {
            _constructorsService = constructorsService;
        }
        [HttpGet("/{season}/constructors/all")]
        public async Task<IActionResult> GetContructorsStandingsData(int season)
        {
            var result = await _constructorsService.GetConstructorsStandingsAsync(season);
            if (result.ConstructorStanding.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("/{season}/constructors/{constructorId}")]
        public async Task<IActionResult> GetConstructorResultsData(int season, string constructorId)
        {
            var result = await _constructorsService.GetConstructorsResultsAsync(season, constructorId);
            if (result.Results.Count == 0) return NotFound();
            return Ok(result);
        }
    }
}

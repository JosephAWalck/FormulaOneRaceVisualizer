using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    public class RacesController : Controller
    {
        private readonly IRacesService _racesService;

        public RacesController(IRacesService racesService)
        {
            _racesService = racesService;
        }

        [HttpGet("/races/{season}")]
        public async Task<IActionResult> GetRacesListData(int season)
        {
            var result = await _racesService.GetRaceListForSeasonAsync(season);
            if (result.Races.Count == 0) return NotFound();
            return Ok(result);
        }
    }
}

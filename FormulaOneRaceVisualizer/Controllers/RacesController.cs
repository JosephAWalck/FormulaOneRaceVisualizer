using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    [Route("api")]
    [ApiController]
    public class RacesController : ControllerBase
    {
        private readonly IRaceService _raceService;

        public RacesController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpGet("{season}/races")]
        public async Task<IActionResult> GetRaceScedule(int season)
        {
            var result = await _raceService.GetSeasonRaces(season);
            if (result == null || result.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("{season}/{round}")]
        public async Task<IActionResult> GetRaceResults(int season, int round)
        {
            var result = await _raceService.GetRaceResultsAsync(season, round);
            if (result == null) return NotFound();
            return Ok(result);

        }
    }
}

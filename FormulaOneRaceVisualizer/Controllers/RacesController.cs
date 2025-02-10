using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    [Route("api/races")]
    [ApiController]
    public class RacesController : ControllerBase
    {
        private readonly IRaceService _raceService;

        public RacesController(IRaceService raceSeervice)
        {
            _raceService = raceSeervice;
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

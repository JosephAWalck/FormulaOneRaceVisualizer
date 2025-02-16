using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    [ApiController]
    [Route("api/laps")]
    public class LapsController : ControllerBase
    {
        private readonly ILapService _lapService;

        public LapsController(ILapService lapService)
        {
            _lapService = lapService;
        }

        [HttpGet("{season}/{round}/{lap}")]
        public async Task<IActionResult> GetLapData(int season, int round, int lap)
        {
            var result = await _lapService.GetLapDataAsync(season, round, lap);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}

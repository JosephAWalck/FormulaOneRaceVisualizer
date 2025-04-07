using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    public class DriversController : Controller
    {
        private readonly IDriversService _driversService;

        public DriversController(IDriversService driversService)
        {
            _driversService = driversService;
        }

        [HttpGet("/{season}/drivers/all")]
        public async Task<IActionResult> GetDriversStandingsData(int season)
        {
            var result = await _driversService.GetDriversStandingsAsync(season);
            if (result.DriverStandings.Count == 0) return NotFound();
            return Ok(result);
        }

    }
}

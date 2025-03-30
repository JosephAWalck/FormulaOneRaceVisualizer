using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    public class SeasonsController : Controller
    {
        private readonly ISeasonService _seasonService;

        public SeasonsController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }
        [HttpGet("/seasons")]
        public async Task<IActionResult> GetSeasonListData()
        {
            var result = await _seasonService.GetSeasonsAsync();
            if (result.Seasons.Count == 0) return NotFound();
            return Ok(result);

        }
    }
}

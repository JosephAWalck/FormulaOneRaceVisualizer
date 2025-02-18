using FormulaOneRaceVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneRaceVisualizer.Controllers
{
    [ApiController]
    [Route("api/driver")]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet("{driverId}")]
        public async Task<IActionResult> GetDriverData(string driverId)
        {
            var result = await _driverService.GetDriverDataAsync(driverId);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}

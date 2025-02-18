using FormulaOneRaceVisualizer.Models;

namespace FormulaOneRaceVisualizer.Services
{
    public interface IDriverService
    {
        Task<Driver> GetDriverDataAsync(string driverId);
    }
}

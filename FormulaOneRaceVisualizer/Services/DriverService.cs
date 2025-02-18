using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.SeasonModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class DriverService : IDriverService
    {
        private readonly HttpClient _httpClient;

        public DriverService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Driver> GetDriverDataAsync(string driverId)
        {
            string url = $"https://ergast.com/api/f1/drivers/{driverId}.json";
            var response = await _httpClient.GetStringAsync(url);
            var driverData = JsonConvert.DeserializeObject<ApiResponse>(response);
            return driverData.MRData.DriverTable.Drivers.FirstOrDefault();


        }
    }
}

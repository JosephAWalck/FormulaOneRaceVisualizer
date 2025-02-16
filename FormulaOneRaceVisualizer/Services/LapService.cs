using FormulaOneRaceVisualizer.Models.LapModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class LapService : ILapService
    {
        private readonly HttpClient _httpClient;

        public LapService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LapApiResponse> GetLapDataAsync(int season, int round, int lap)
        {
            string url = $"https://ergast.com/api/f1/{season}/{round}/laps/{lap}.json";
            var response = await _httpClient.GetStringAsync(url);
            var lapData = JsonConvert.DeserializeObject<LapApiResponse>(response);
            return lapData;
        }
    }
}

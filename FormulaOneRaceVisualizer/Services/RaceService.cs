using FormulaOneRaceVisualizer.Models;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FormulaOneRaceVisualizer.Services
{
    public class RaceService : IRaceService
    {
        private readonly HttpClient _httpClient;

        public RaceService(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }

        public async Task<RaceApiResponse> GetRaceResultsAsync(int season, int round)
        {
            string url = $"https://ergast.com/api/f1/{season}/{round}/results.json";
            var response = await _httpClient.GetStringAsync(url);
            var raceData = JsonConvert.DeserializeObject<RaceApiResponse>(response);
            if (raceData == null) return null;
            return raceData;
            
        }

    }
}

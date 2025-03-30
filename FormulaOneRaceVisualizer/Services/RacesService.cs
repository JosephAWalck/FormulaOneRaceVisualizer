using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.ResponseModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class RacesService : IRacesService
    {
        private readonly HttpClient _httpClient;

        public RacesService(HttpClient httpClient, IOptions<ExternalApiOptions> options)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(options.Value.JolpicaApiBaseUrl);
        }

        public async Task<RaceListResponse> GetRaceListForSeasonAsync(int seasonId)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/races");
            var raceListData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var raceListResponse = new RaceListResponse();
            foreach(var race in raceListData.MRData.RacesTable.Races)
            {
                raceListResponse.Races.Add(race.Circuit.Location.country);
            }
            return raceListResponse;
        }
    }
    
}

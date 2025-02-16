using FormulaOneRaceVisualizer.Models.DTOs;
using FormulaOneRaceVisualizer.Models.RaceModels;
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

        public async Task<RaceDTO> GetRaceResultsAsync(int season, int round)
        {
            string url = $"https://ergast.com/api/f1/{season}/{round}/results.json";
            var response = await _httpClient.GetStringAsync(url);
            var raceData = JsonConvert.DeserializeObject<RaceApiResponse>(response);
            var race = raceData.MRData.RaceTable.Races.FirstOrDefault();
            return new RaceDTO
            {
                RaceName = race.RaceName,
                Circuit = race.Circuit,
                Date = race.Date,
                Time = race.Time,
                Results = race.Results,
            };
            
        }

    }
}

using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.DTOs;
using FormulaOneRaceVisualizer.Models.RaceModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FormulaOneRaceVisualizer.Services
{
    public class RaceService : IRaceService
    {
        private readonly HttpClient _httpClient;

        public RaceService(HttpClient httpClient, IOptions<ExternalApiOptions> options) 
        { 
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(options.Value.JolpicaApiBaseUrl);
        }

        public async Task<List<RaceOverview>> GetSeasonRaces(int season)
        {
            var response = await _httpClient.GetStringAsync($"{season}/races");
            var seasonRaceListData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var seasonRaceList = seasonRaceListData.MRData.RaceTable.Races;
            var seasonRaceResult = new List<RaceOverview>();
            foreach(var race in seasonRaceList)
            {
                seasonRaceResult.Add(new RaceOverview
                {
                    Round = race.Round,
                    RaceName = race.RaceName,
                    Circuit = race.Circuit,

                });
            }
            return seasonRaceResult;

        }

        public async Task<RaceDTO> GetRaceResultsAsync(int season, int round)
        {
            string url = $"{season}/{round}/results.json";
            var response = await _httpClient.GetStringAsync(url);
            var raceData = JsonConvert.DeserializeObject<ApiResponse>(response);
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

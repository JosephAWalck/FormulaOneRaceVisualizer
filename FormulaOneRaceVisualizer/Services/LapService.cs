using FormulaOneRaceVisualizer.Models.DTOs;
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

        public async Task<LapDTO> GetLapDataAsync(int season, int round, int lap)
        {
            string url = $"https://ergast.com/api/f1/{season}/{round}/laps/{lap}.json";
            var response = await _httpClient.GetStringAsync(url);
            var lapData = JsonConvert.DeserializeObject<LapApiResponse>(response);
            var race = lapData.MRData.RaceTable.Races.FirstOrDefault();
            if (race == null) return null;
            return new LapDTO
            {
                RaceName = race.RaceName,
                Circuit = race.Circuit,
                Date = race.Date,
                Time = race.Time,
                Laps = race.Laps,
            };

        }
    }
}

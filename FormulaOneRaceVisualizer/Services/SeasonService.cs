using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.DTOs;
using FormulaOneRaceVisualizer.Models.SeasonModels;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly HttpClient _httpClient;

        public SeasonService(HttpClient httpClient)
        {
            _httpClient = httpClient; ;
        }

        public async Task<SeasonDTO> GetSeasonsAsync()
        {
            string url = $"https://ergast.com/api/f1/seasons.json?limit={Int32.MaxValue}";
            var response = await _httpClient.GetStringAsync(url);
            var seasonData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var seasonResult = new SeasonDTO();
            foreach(var season in seasonData.MRData.SeasonTable.Seasons)
            {
                seasonResult.Seasons.Add(season);
            }
            return seasonResult;
        }
    }
}

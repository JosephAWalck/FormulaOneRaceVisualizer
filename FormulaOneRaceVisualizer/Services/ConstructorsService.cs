using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.ResponseModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class ConstructorsService : IConstructorsService
    {
        private readonly HttpClient _httpClient;

        public ConstructorsService(HttpClient httpClient, IOptions<ExternalApiOptions> options)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(options.Value.JolpicaApiBaseUrl);
        }

        public  async Task<ConstructorStandingsResponse> GetConstructorsStandingsAsync(int seasonId)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/constructorstandings");
            var constructorsStandingsData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var constructorsStandingsResponse = new ConstructorStandingsResponse();
            foreach(var result in constructorsStandingsData.MRData.StandingsTable.StandingsLists[0].ConstructorStandings)
            {
                constructorsStandingsResponse.ConstructorStanding.Add(
                    new ConstructorStandingResponse
                    {
                        Position = result.Position,
                        ConstructorName = result.Constructor.Name,
                        Points = result.Points,
                    });
            } 
            return constructorsStandingsResponse;
        }

        public async Task<ConstructorResultsResponse> GetConstructorsResultsAsync(int seasonId, string constructorId)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/constructors/{constructorId}/results");
            var constructorsResultsData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var constructorResultsResponse = new ConstructorResultsResponse();
            foreach(var race in constructorsResultsData.MRData.RacesTable.Races)
            {
                int points = race.Results[0].Points + race.Results[1].Points;
                constructorResultsResponse.Results.Add(
                    new ConstructorResult
                    {
                        GrandPrix = race.Results[0].Constructor.Name,
                        Date = race.Date,
                        Points = points,
                    });
            }
            Console.WriteLine(constructorResultsResponse.ToString()); 
            return constructorResultsResponse;
        }
    }
}

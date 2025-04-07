using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.DriverModels;
using FormulaOneRaceVisualizer.Models.ResponseModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FormulaOneRaceVisualizer.Services
{
    public class DriversService : IDriversService
    {
        private readonly HttpClient _httpClient;

        public DriversService(HttpClient httpClient, IOptions<ExternalApiOptions> options)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(options.Value.JolpicaApiBaseUrl);
        }

        public async Task<DriversStandingsResponse> GetDriversStandingsAsync(int seasonId)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/driverstandings");
            var driversStandingsData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var driversStandingsResponse = new DriversStandingsResponse();
            foreach(var result in driversStandingsData.MRData.StandingsTable.StandingsLists[0].DriverStandings)
            {
                driversStandingsResponse.DriverStandings.Add(
                    new DriverStandingResponse
                    {
                        Position = result.Position,
                        DriverName = result.Driver.GivenName + " " + result.Driver.FamilyName,
                        Nationality = result.Driver.Nationality,
                        ConstructorName = result.Constructors[0].Name,
                        Points = result.Points
                    });

            }
            return driversStandingsResponse;

        }
    }
}

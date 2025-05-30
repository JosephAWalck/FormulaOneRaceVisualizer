﻿using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.RaceModels;
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
                raceListResponse.Races.Add(race.Circuit.Location.Country);
            }
            return raceListResponse;
        }

        public async Task<RaceResultOverviewResponse> GetRaceResultsOverviewAsync(int seasonId)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/results/1");
            var resultsOverviewData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var raceResultsOverviewResponse = new RaceResultOverviewResponse();
            foreach(var race in resultsOverviewData.MRData.RacesTable.Races)
            {
                raceResultsOverviewResponse.RaceResultsOverview.Add(
                    new RaceResultsOverview
                    {
                        GrandPrix = race.Circuit.Location.Country,
                        Date = race.Date,
                        Winner = race.Results[0].Driver.GivenName + " " + race.Results[0].Driver.FamilyName,
                        Car = race.Results[0].Constructor.Name,
                        Laps = race.Results[0].Laps,
                        Time = race.Results[0].Time.Time,
                    });
            }
            return raceResultsOverviewResponse;
        }

        public async Task<RaceResultsResponse> GetRaceResultsAsync(int seasonId, int round)
        {
            var response = await _httpClient.GetStringAsync($"{seasonId}/{round}/results");
            var raceResultsData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var raceResultsResponse = new RaceResultsResponse();
            foreach(var result in raceResultsData.MRData.RacesTable.Races[0].Results)
            {
                raceResultsResponse.RaceResults.Add(
                    new RaceResult
                    {
                        Position = result.Position,
                        Number = result.Number,
                        Driver = result.Driver.GivenName + " " + result.Driver.FamilyName,
                        Constructor = result.Constructor.Name,
                        Laps = result.Laps,
                        Time = result.Time.Time,
                    });
            }
            return raceResultsResponse;
        }
    }
    
}

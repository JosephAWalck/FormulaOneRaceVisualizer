﻿using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Models;
using FormulaOneRaceVisualizer.Models.ResponseModels;
using FormulaOneRaceVisualizer.Models.SeasonModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FormulaOneRaceVisualizer.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly HttpClient _httpClient;

        public SeasonService(HttpClient httpClient, IOptions<ExternalApiOptions> options)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(options.Value.JolpicaApiBaseUrl);
        }

        public async Task<SeasonsResponse> GetSeasonsAsync()
        {
            var response = await _httpClient.GetStringAsync(
                $"seasons?limit={DateTime.Now.Year - 1950 + 1}"
                );
            var seasonData = JsonConvert.DeserializeObject<ApiResponse>(response);
            var seasonResult = new SeasonsResponse();
            foreach(var season in seasonData.MRData.SeasonTable.Seasons)
            {
                seasonResult.Seasons.Add(season.SeasonName);
            }
            return seasonResult;
            
        }
    }
}

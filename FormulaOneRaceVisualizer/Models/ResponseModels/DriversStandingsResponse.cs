using FormulaOneRaceVisualizer.Models.DriverModels;

namespace FormulaOneRaceVisualizer.Models.ResponseModels
{
    public class DriversStandingsResponse
    {
        public List<DriverStandingResponse> DriverStandings { get; set; } = new List<DriverStandingResponse>();
    }
}

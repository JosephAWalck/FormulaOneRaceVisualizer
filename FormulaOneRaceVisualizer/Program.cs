using FormulaOneRaceVisualizer.Configs;
using FormulaOneRaceVisualizer.Services;

var builder = WebApplication.CreateBuilder(args);

var jolpicaBaseUrl = builder.Configuration["JolpicaApi:BaseUrl"]
    ?? Environment.GetEnvironmentVariable("JolpicaApiBaseUrl");

// Bind env var
builder.Services.Configure<ExternalApiOptions>(options =>
{
    options.JolpicaApiBaseUrl = jolpicaBaseUrl;
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Service DI
builder.Services.AddScoped<ISeasonService, SeasonService>();
builder.Services.AddScoped<IRacesService, RacesService>();
builder.Services.AddScoped<IDriversService, DriversService>();
builder.Services.AddScoped<IConstructorsService, ConstructorsService>();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

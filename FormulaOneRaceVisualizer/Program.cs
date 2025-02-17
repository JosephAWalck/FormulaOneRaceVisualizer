using FormulaOneRaceVisualizer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Service DI
builder.Services.AddScoped<IRaceService, RaceService>();
builder.Services.AddScoped<ILapService, LapService>();
builder.Services.AddScoped<ISeasonService, SeasonService>();
builder.Services.AddScoped<IDriverService, DriverService>();
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

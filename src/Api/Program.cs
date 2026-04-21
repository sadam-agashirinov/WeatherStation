using App.Services.Interfaces;
using Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weather/forecast", async (IWeatherService weatherService, decimal lat, decimal lon, int days) =>
    {
        var forecast = await weatherService.GetForecastAsync(lat, lon, days);
        
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.MapGet("/weather/current/", async (IWeatherService weatherService, decimal lat, decimal lon)  =>
    {
        var currentWeather = await weatherService.GetCurrentWeatherAsync(lat, lon);
        
        return currentWeather;
    })
    .WithName("GetCurrentWeather")
    .WithOpenApi();

app.Run();
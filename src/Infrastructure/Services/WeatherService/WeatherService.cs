using App.DTOs.Responses.WeatherService;
using App.Services.Interfaces;
using Infrastructure.Helpers;
using Infrastructure.Services.WeatherService.Options;
using IO.Swagger.Api;
using Microsoft.Extensions.Options;

namespace Infrastructure.Services.WeatherService;

/// <summary>
/// Сервис получения информации о погоде
/// </summary>
public class WeatherService : IWeatherService
{
    private readonly APIsApi _apiWeather;
    
    public WeatherService(IOptions<WeatherServiceOptions> options)
    {
        _apiWeather = new APIsApi();
        _apiWeather.Configuration.ApiKey.Add("key", options.Value.ApiKey);
    }
    
    /// <inheritdoc/>
    public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(decimal lat,
        decimal lon,
        CancellationToken cancellationToken = default)
    {
        if (!GeoHelper.IsValidCoordinates(lat, lon))
            throw new ArgumentException("Неверные координаты.");
        
        var realTimeWeather = await _apiWeather.RealtimeWeatherAsync($"{lat},{lon}", "ru");

        return new CurrentWeatherResponse();
    }

    /// <inheritdoc/>
    public async Task<ForecastWeatherResponse> GetForecastAsync(decimal lat,
        decimal lon,
        int days,
        CancellationToken cancellationToken = default)
    {
        if (days is >= 1 and <= 14) 
            throw new ArgumentOutOfRangeException($"{nameof(days)} должен быть от 1-14.");

        if (!GeoHelper.IsValidCoordinates(lat, lon))
            throw new ArgumentException("Неверные координаты.");
        
        var forecastWeather = await _apiWeather.ForecastWeatherAsync($"{lat},{lon}", days);

        return new ForecastWeatherResponse();
    }
}
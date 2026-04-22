using App.DTOs.Responses.WeatherService;
using App.Services.Interfaces;
using Infrastructure.Extensions;
using Infrastructure.Helpers;
using Infrastructure.Services.WeatherService.Options;
using IO.Swagger.Api;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

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
        _apiWeather.Configuration.ApiKey.TryAdd("key", options.Value.ApiKey);
    }
    
    /// <inheritdoc/>
    public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(decimal lat,
        decimal lon,
        CancellationToken cancellationToken = default)
    {
        if (!GeoHelper.IsValidCoordinates(lat, lon))
            throw new ArgumentException("Неверные координаты.");
        
        var realTimeWeatherResponse = (JObject)await _apiWeather.RealtimeWeatherAsync($"{lat},{lon}", "ru");
        
        var response = new CurrentWeatherResponse()
        {
            Location = ApiWeatherHelper.GetLocation(realTimeWeatherResponse).CreateDto(),
            Current = ApiWeatherHelper.GetCurrent(realTimeWeatherResponse).CreateDto()
        };

        return response;
    }

    /// <inheritdoc/>
    public async Task<ForecastWeatherResponse> GetForecastAsync(decimal lat,
        decimal lon,
        int days,
        CancellationToken cancellationToken = default)
    {
        if (days is < 1 or > 14) 
            throw new ArgumentOutOfRangeException($"{nameof(days)} должен быть от 1-14.");

        if (!GeoHelper.IsValidCoordinates(lat, lon))
            throw new ArgumentException("Неверные координаты.");
        
        var forecastWeatherResponse = (JObject)await _apiWeather.ForecastWeatherAsync($"{lat},{lon}", days, lang: "ru");
        
        var response = new ForecastWeatherResponse()
        {
            Location = ApiWeatherHelper.GetLocation(forecastWeatherResponse).CreateDto(),
            Current = ApiWeatherHelper.GetCurrent(forecastWeatherResponse).CreateDto(),
            Forecast = ApiWeatherHelper.GetForecast(forecastWeatherResponse).CreateDto()
        };

        return response;
    }
}
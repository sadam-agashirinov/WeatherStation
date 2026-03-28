using App.DTOs.Responses.WeatherService;
using App.Services.Interfaces;

namespace App.Services;

/// <summary>
/// Сервис получения информации о погоде
/// </summary>
public class WeatherService : IWeatherService
{
    /// <inheritdoc/>
    public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(double lat,
        double lon,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public async Task<ForecastWeatherResponse> GetForecastAsync(double lat,
        double lon,
        int days,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
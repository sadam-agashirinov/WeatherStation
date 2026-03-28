using App.DTOs.Responses.WeatherService;

namespace App.Services.Interfaces;

/// <summary>
/// Сервис получения информации о погоде
/// </summary>
public interface IWeatherService
{
    /// <summary>
    /// Получить текущую погоду по координатам.
    /// </summary>
    /// <param name="lat">Широта</param>
    /// <param name="lon">Долгота</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Ответ с текущей погодой</returns>
    Task<CurrentWeatherResponse> GetCurrentWeatherAsync(
        double lat,
        double lon,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Получить прогноз погоды на указанное количество дней.
    /// </summary>
    /// <param name="lat">Широта</param>
    /// <param name="lon">Долгота</param>
    /// <param name="days">Количество дней (максимум 3)</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Ответ с прогнозом</returns>
    Task<ForecastWeatherResponse> GetForecastAsync(
        double lat,
        double lon,
        int days,
        CancellationToken cancellationToken = default);
}
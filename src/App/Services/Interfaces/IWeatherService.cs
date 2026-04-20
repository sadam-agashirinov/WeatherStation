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
        decimal lat,
        decimal lon,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Получить прогноз погоды на указанное количество дней.
    /// </summary>
    /// <param name="lat">Широта</param>
    /// <param name="lon">Долгота</param>
    /// <param name="days"> Количество дней (от 1 до 14)</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Ответ с прогнозом</returns>
    Task<ForecastWeatherResponse> GetForecastAsync(
        decimal lat,
        decimal lon,
        int days,
        CancellationToken cancellationToken = default);
}
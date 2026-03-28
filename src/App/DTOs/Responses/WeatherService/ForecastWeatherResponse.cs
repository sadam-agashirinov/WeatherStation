namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Прогноз погоды
/// </summary>
public class ForecastWeatherResponse
{
    /// <summary>
    /// Информация о местности 
    /// </summary>
    public Location Location { get; private set; }

    /// <summary>
    /// Текущая погода
    /// </summary>
    public CurrentWeather Current { get; private set; }

    /// <summary>
    /// Прогноз погоды по дням
    /// </summary>
    public IEnumerable<ForecastWeather> Days { get; private set; }
}
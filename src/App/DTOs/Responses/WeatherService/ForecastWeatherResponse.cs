namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Прогноз погоды
/// </summary>
public class ForecastWeatherResponse
{
    /// <summary>
    /// Информация о местности 
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    /// Текущая погода
    /// </summary>
    public CurrentWeather Current { get; set; }

    /// <summary>
    /// Прогноз погоды по дням
    /// </summary>
    public IEnumerable<ForecastDayWeather> Forecast { get; set; }
}
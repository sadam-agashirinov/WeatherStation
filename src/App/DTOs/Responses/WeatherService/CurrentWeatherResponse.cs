namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Информация о текущем состоянии погоды
/// </summary>
public class CurrentWeatherResponse
{
    /// <summary>
    /// Информация о местности 
    /// </summary>
    public Location Location { get; private set; }

    /// <summary>
    /// Текущая погода
    /// </summary>
    public CurrentWeather Current { get; private set; }
}
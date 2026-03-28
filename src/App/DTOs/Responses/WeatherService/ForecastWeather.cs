namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Прогноз погоды по дням
/// </summary>
public class ForecastWeather
{
    /// <summary>
    /// Текущее значение даты
    /// </summary>
    public DateOnly Date { get; private set; }

    /// <summary>
    /// Представляет дневные агрегированные данные прогноза погоды
    /// </summary>
    public ForecastDailyWeather Daily { get; private set; }
    
    /// <summary>
    /// Астрономические данные
    /// </summary>
    public Astro Astro { get; private set; }

    /// <summary>
    /// По часовое значение данных прогноза погоды
    /// </summary>
    public IEnumerable<ForecastDailyHourWeather> Hours { get; private set; }
}
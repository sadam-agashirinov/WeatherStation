namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Прогноз погоды по дням
/// </summary>
public class ForecastDayWeather
{
    /// <summary>
    /// Текущее значение даты
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Представляет дневные агрегированные данные прогноза погоды
    /// </summary>
    public ForecastDailyWeather Daily { get; set; }

    /// <summary>
    /// Астрономические данные
    /// </summary>
    public Astro Astro { get; set; }

    /// <summary>
    /// По часовое значение данных прогноза погоды
    /// </summary>
    public IEnumerable<ForecastDailyHourWeather> Hours { get; set; }
}
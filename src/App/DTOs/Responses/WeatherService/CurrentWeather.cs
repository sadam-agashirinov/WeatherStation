namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Информация о текущем состоянии погоды
/// </summary>
public class CurrentWeather
{
    /// <summary>
    /// Дата и время последнего обновления информации
    /// </summary>
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Температура в цельсиях
    /// </summary>
    public decimal? TemperatureC { get; set; }

    /// <summary>
    /// Текущее значение суток - день или ночь
    /// </summary>
    public bool IsDay { get; set; }

    /// <summary>
    /// Скорость ветра км/ч
    /// </summary>
    public decimal? WindKph { get; set; }

    /// <summary>
    /// Направление ветра
    /// </summary>
    public string WindDirection { get; set; }

    /// <summary>
    /// Осадки 
    /// </summary>
    public decimal? Precip { get; set; }

    /// <summary>
    /// Влажность %
    /// </summary>
    public decimal? Humidity { get; set; }

    /// <summary>
    /// Облачность %
    /// </summary>
    public decimal? Cloud { get; set; }

    /// <summary>
    /// Описание погодных условий
    /// </summary>
    public Condition Condition { get; set; }
}
namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Информация о текущем состоянии погоды
/// </summary>
public class CurrentWeather
{
    /// <summary>
    /// Дата и время последнего обновления информации
    /// </summary>
    public DateTime LastUpdated { get; private set; }

    /// <summary>
    /// Температура в цельсиях
    /// </summary>
    public decimal TemperatureC { get; private set; }

    /// <summary>
    /// Текущее значение суток - день или ночь
    /// </summary>
    public bool IsDay { get; private set; }

    /// <summary>
    /// Скорость ветра км/ч
    /// </summary>
    public decimal WindKph { get; private set; }

    /// <summary>
    /// Направление ветра
    /// </summary>
    public string WindDirection { get; private set; }

    /// <summary>
    /// Осадки 
    /// </summary>
    public decimal Precip { get; private set; }

    /// <summary>
    /// Влажность %
    /// </summary>
    public int Humidity { get; private set; }

    /// <summary>
    /// Облачность %
    /// </summary>
    public int Cloud { get; private set; }

    /// <summary>
    /// Описание погодных условий
    /// </summary>
    public Condition Condition { get; private set; }
}
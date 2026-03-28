namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Информация о местности
/// </summary>
public class Location
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Регион
    /// </summary>
    public string Region { get; private set; }

    /// <summary>
    /// Страна
    /// </summary>
    public string Country { get; private set; }

    /// <summary>
    /// Широта
    /// </summary>
    public decimal Latitude { get; private set; }

    /// <summary>
    /// Долгота
    /// </summary>
    public decimal Longitude { get; private set; }
}
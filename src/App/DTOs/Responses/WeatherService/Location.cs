namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Информация о местности
/// </summary>
public class Location
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Регион
    /// </summary>
    public string Region { get; set; }

    /// <summary>
    /// Страна
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Широта
    /// </summary>
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Долгота
    /// </summary>
    public decimal? Longitude { get; set; }
}
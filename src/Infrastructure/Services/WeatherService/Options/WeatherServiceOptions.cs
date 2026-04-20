namespace Infrastructure.Services.WeatherService.Options;

/// <summary>
/// Опции сервиса погоды
/// </summary>
public class WeatherServiceOptions
{
    /// <summary>
    /// Название секции в конфигурации
    /// </summary>
    public const string Section = "Weather";

    /// <summary>
    /// API ключ
    /// </summary>
    public required string ApiKey { get; set; }
}
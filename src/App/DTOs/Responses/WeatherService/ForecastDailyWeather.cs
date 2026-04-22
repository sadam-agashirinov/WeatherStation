namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Представляет дневные агрегированные данные прогноза погоды
/// </summary>
public class ForecastDailyWeather
{
    /// <summary>
    ///Максимальная температура в градусах Цельсия
    ///</summary>
    public decimal? MaxtempC { get; set; }

    /// <summary>
    ///Минимальная температура в градусах Цельсия
    ///</summary>
    public decimal? MintempC { get; set; }

    /// <summary>
    ///Средняя температура в градусах Цельсия
    ///</summary>
    public decimal? AvgtempC { get; set; }

    /// <summary>
    ///Максимальная скорость ветра в километрах в час
    ///</summary>
    public decimal? MaxwindKph { get; set; }

    /// <summary>
    ///Общее количество осадков в миллиметрах
    ///</summary>
    public decimal? TotalprecipMm { get; set; }

    /// <summary>
    ///Средняя видимость в километрах
    ///</summary>
    public decimal? AvgvisKm { get; set; }

    /// <summary>
    ///Средняя относительная влажность в процентах
    ///</summary>
    public decimal? Avghumidity { get; set; }

    /// <summary>
    ///Будет ли дождь в течение дня
    ///</summary>
    public bool WillItRain { get; set; }

    /// <summary>
    ///Вероятность дождя в процентах
    ///</summary>
    public decimal? ChanceOfRain { get; set; }

    /// <summary>
    ///Будет ли снег в течение дня
    ///</summary>
    public bool WillItSnow { get; set; }

    /// <summary>
    ///Вероятность снега в процентах
    ///</summary>
    public decimal? ChanceOfSnow { get; set; }

    /// <summary>
    ///Условия погоды (текст, иконка, код)
    ///</summary>
    public Condition Condition { get; set; }

    /// <summary>
    ///Ультрафиолетовый индекс
    ///</summary>
    public int? Uv { get; set; }
}
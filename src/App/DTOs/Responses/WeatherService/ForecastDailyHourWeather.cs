namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Почасовой прогноз
/// </summary>
public class ForecastDailyHourWeather
{
    /// <summary>
    /// Дата и время
    ///</summary>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Температура в градусах Цельсия
    /// </summary>
    public decimal? TempC { get; set; }

    /// <summary>
    /// Индикатор дневного времени
    /// </summary>
    public bool IsDay { get; set; }

    /// <summary>
    /// Состояние погоды (текст, иконка, код)
    /// </summary>
    public Condition Condition { get; set; }

    /// <summary>
    /// Скорость ветра в километрах в час
    /// </summary>
    public decimal? WindKph { get; set; }

    /// <summary>
    /// Направление ветра в виде строки (например, "NNE")
    /// </summary>
    public string WindDir { get; set; }

    /// <summary>
    /// Давление в миллибарах
    /// </summary>
    public decimal? PressureMb { get; set; }

    /// <summary>
    /// Давление в дюймах ртутного столба
    /// </summary>
    public decimal? PressureIn { get; set; }

    /// <summary>
    /// Количество осадков в миллиметрах
    /// </summary>
    public decimal? PrecipMm { get; set; }

    /// <summary>
    /// Относительная влажность в процентах
    /// </summary>
    public decimal? Humidity { get; set; }

    /// <summary>
    /// Облачность в процентах
    /// </summary>
    public decimal? Cloud { get; set; }

    /// <summary>
    /// Ощущаемая температура в градусах Цельсия
    /// </summary>
    public decimal? FeelslikeC { get; set; }

    /// <summary>
    /// Будет ли дождь
    /// </summary>
    public bool WillItRain { get; set; }

    /// <summary>
    /// Вероятность дождя в процентах
    /// </summary>
    public decimal? ChanceOfRain { get; set; }

    /// <summary>
    /// Будет ли снег
    /// </summary>
    public bool WillItSnow { get; set; }

    /// <summary>
    /// Вероятность снега в процентах
    /// </summary>
    public decimal? ChanceOfSnow { get; set; }

    /// <summary>
    /// Видимость в километрах
    /// </summary>
    public decimal? VisibleKm { get; set; }

    /// <summary>
    /// Порыв ветра в километрах в час
    /// </summary>
    public decimal? GustKph { get; set; }

    /// <summary>
    /// Ультрафиолетовый индекс
    /// </summary>
    public int? Uv { get; set; }
}
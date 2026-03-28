namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Почасовой прогноз
/// </summary>
public class ForecastDailyHourWeather
{
    /// <summary>
    /// Дата и время
    ///</summary>
    public DateTime DateTime { get; private set; }

    /// <summary>
    /// Температура в градусах Цельсия
    /// </summary>
    public double TempC { get; private set; }

    /// <summary>
    /// Индикатор дневного времени
    /// </summary>
    public bool IsDay { get; private set; }

    /// <summary>
    /// Состояние погоды (текст, иконка, код)
    /// </summary>
    public Condition Condition { get; private set; }

    /// <summary>
    /// Скорость ветра в километрах в час
    /// </summary>
    public double WindKph { get; private set; }

    /// <summary>
    /// Направление ветра в виде строки (например, "NNE")
    /// </summary>
    public string WindDir { get; private set; }

    /// <summary>
    /// Давление в миллибарах
    /// </summary>
    public double PressureMb { get; private set; }

    /// <summary>
    /// Давление в дюймах ртутного столба
    /// </summary>
    public double PressureIn { get; private set; }

    /// <summary>
    /// Количество осадков в миллиметрах
    /// </summary>
    public double PrecipMm { get; private set; }

    /// <summary>
    /// Количество снега в сантиметрах
    /// </summary>
    public double SnowCm { get; private set; }

    /// <summary>
    /// Относительная влажность в процентах
    /// </summary>
    public int Humidity { get; private set; }

    /// <summary>
    /// Облачность в процентах
    /// </summary>
    public int Cloud { get; private set; }

    /// <summary>
    /// Ощущаемая температура в градусах Цельсия
    /// </summary>
    public double FeelslikeC { get; private set; }
    
    /// <summary>
    /// Будет ли дождь
    /// </summary>
    public bool WillItRain { get; private set; }

    /// <summary>
    /// Вероятность дождя в процентах
    /// </summary>
    public int ChanceOfRain { get; private set; }

    /// <summary>
    /// Будет ли снег
    /// </summary>
    public bool WillItSnow { get; private set; }

    /// <summary>
    /// Вероятность снега в процентах
    /// </summary>
    public int ChanceOfSnow { get; private set; }

    /// <summary>
    /// Видимость в километрах
    /// </summary>
    public double VisibleKm { get; private set; }

    /// <summary>
    /// Порыв ветра в километрах в час
    /// </summary>
    public double GustKph { get; private set; }

    /// <summary>
    /// Ультрафиолетовый индекс
    /// </summary>
    public int Uv { get; private set; }
}
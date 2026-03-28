namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Представляет дневные агрегированные данные прогноза погоды
/// </summary>
public class ForecastDailyWeather
{
    /// <summary>
    ///Максимальная температура в градусах Цельсия
    ///</summary>
    public double MaxtempC { get; private set; }

    /// <summary>
    ///Минимальная температура в градусах Цельсия
    ///</summary>
    public double MintempC { get; private set; }

    /// <summary>
    ///Средняя температура в градусах Цельсия
    ///</summary>
    public double AvgtempC { get; private set; }

    /// <summary>
    ///Максимальная скорость ветра в километрах в час
    ///</summary>
    public double MaxwindKph { get; private set; }

    /// <summary>
    ///Общее количество осадков в миллиметрах
    ///</summary>
    public double TotalprecipMm { get; private set; }

    /// <summary>
    ///Общее количество снега в сантиметрах
    ///</summary>
    public double TotalsnowCm { get; private set; }

    /// <summary>
    ///Средняя видимость в километрах
    ///</summary>
    public double AvgvisKm { get; private set; }

    /// <summary>
    ///Средняя относительная влажность в процентах
    ///</summary>
    public int Avghumidity { get; private set; }

    /// <summary>
    ///Будет ли дождь в течение дня
    ///</summary>
    public bool DailyWillItRain { get; private set; }

    /// <summary>
    ///Вероятность дождя в процентах
    ///</summary>
    public int DailyChanceOfRain { get; private set; }

    /// <summary>
    ///Будет ли снег в течение дня
    ///</summary>
    public bool DailyWillItSnow { get; private set; }

    /// <summary>
    ///Вероятность снега в процентах
    ///</summary>
    public int DailyChanceOfSnow { get; private set; }

    /// <summary>
    ///Условия погоды (текст, иконка, код)
    ///</summary>
    public Condition Condition { get; private set; }

    /// <summary>
    ///Ультрафиолетовый индекс
    ///</summary>
    public double Uv { get; private set; }
}
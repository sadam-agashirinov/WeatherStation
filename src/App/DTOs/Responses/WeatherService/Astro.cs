namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Представляет астрономические данные: восход/закат солнца и луны, фазу луны и т.д.
/// </summary>
public class Astro
{
    /// <summary>
    /// Время восхода солнца (например, "06:11 AM")
    /// </summary>
    public string Sunrise { get; private set; }

    /// <summary>
    /// Время заката солнца (например, "06:59 PM")
    /// </summary>
    public string Sunset { get; private set; }

    /// <summary>
    /// Время восхода луны (например, "12:57 PM")
    /// </summary>
    public string Moonrise { get; private set; }

    /// <summary>
    /// Время захода луны (например, "05:05 AM")
    /// </summary>
    public string Moonset { get; private set; }

    /// <summary>
    /// Фаза луны (например, "Waxing Gibbous")
    /// </summary>
    public string MoonPhase { get; private set; }

    /// <summary>
    /// Освещённость луны в процентах (0–100)
    /// </summary>
    public int MoonIllumination { get; private set; }

    /// <summary>
    /// Индикатор того, находится ли луна над горизонтом
    /// </summary>
    public bool IsMoonUp { get; private set; }

    /// <summary>
    /// Индикатор того, находится ли солнце над горизонтом
    /// </summary>
    public bool IsSunUp { get; private set; }
}
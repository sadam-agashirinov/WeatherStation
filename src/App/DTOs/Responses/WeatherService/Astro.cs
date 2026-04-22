namespace App.DTOs.Responses.WeatherService;

/// <summary>
/// Представляет астрономические данные: восход/закат солнца и луны, фазу луны и т.д.
/// </summary>
public class Astro
{
    /// <summary>
    /// Время восхода солнца
    /// </summary>
    public string Sunrise { get; set; }

    /// <summary>
    /// Время заката солнца
    /// </summary>
    public string Sunset { get; set; }

    /// <summary>
    /// Время восхода луны
    /// </summary>
    public string Moonrise { get; set; }

    /// <summary>
    /// Время захода луны
    /// </summary>
    public string Moonset { get; set; }

    /// <summary>
    /// Фаза луны
    /// </summary>
    public string MoonPhase { get; set; }

    /// <summary>
    /// Освещённость луны в процентах (0–100)
    /// </summary>
    public int MoonIllumination { get; set; }
}
namespace Infrastructure.Helpers;

/// <summary>
/// Класс для работы с гео данными
/// </summary>
public static class GeoHelper
{
    private const decimal MinLat = -90m;
    private const decimal MaxLat = 90m;
    private const decimal MinLon = -180m;
    private const decimal MaxLon = 180m;

    /// <summary>
    /// Проверка координат на валидность
    /// </summary>
    /// <param name="lat">Широта</param>
    /// <param name="lon">Долгота</param>
    public static bool IsValidCoordinates(decimal lat, decimal lon)
    {
        return lat is >= MinLat and <= MaxLat &&
               lon is >= MinLon and <= MaxLon;
    }
}
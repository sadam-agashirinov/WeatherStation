using App.DTOs.Responses.WeatherService;
using IO.Swagger.Model;
using Location = App.DTOs.Responses.WeatherService.Location;

namespace Infrastructure.Extensions;

public static class MappingExtensions
{
    public static Location CreateDto(this IO.Swagger.Model.Location location) => new()
    {
        Name = location.Name,
        Country = location.Country,
        Region = location.Region,
        Latitude = location.Lat,
        Longitude = location.Lon
    };
    
    public static CurrentWeather CreateDto(this IO.Swagger.Model.Current current) => new()
    {
        LastUpdated = DateTime.Parse(current.LastUpdated),
        TemperatureC = current.TempC,
        IsDay = current.IsDay is 1,
        WindKph = current.WindKph,
        WindDirection = current.WindDir,
        Precip = current.PrecipMm,
        Humidity = current.Humidity,
        Cloud = current.Cloud,
        Condition = current.Condition.CreateDto()
    };

    private static Condition CreateDto(this IO.Swagger.Model.CurrentCondition condition) => new()
    {
        Text = condition.Text,
        Icon = condition.Icon,
        Code = condition.Code
    };

    public static IEnumerable<ForecastDayWeather> CreateDto(this IO.Swagger.Model.Forecast forecast)
    {
        var result = new List<ForecastDayWeather>(forecast.Forecastday.Count);
        
        foreach (var forecastday in forecast.Forecastday)
        {
            result.Add(new ForecastDayWeather()
            {
                Date = DateOnly.FromDateTime(forecastday.Date.Value),
                Astro = forecastday.Astro.CreateDto(),
                Hours = forecastday.Hour.ConvertAll(CreateDto),
                Daily = forecastday.Day.CreateDto()
            });
        }
        
        return result;
    }

    private static Astro CreateDto(this IO.Swagger.Model.ForecastAstro astro) => new()
    {
        Sunrise = astro.Sunrise,
        Sunset = astro.Sunset,
        Moonrise = astro.Moonrise,
        Moonset = astro.Moonset,
        MoonIllumination = int.Parse(astro.MoonIllumination),
        MoonPhase = astro.MoonPhase
    };

    private static ForecastDailyHourWeather CreateDto(ForecastHour hour) => new()
    {
        DateTime = DateTime.Parse(hour.Time),
        TempC = hour.TempC,
        IsDay = hour.IsDay is 1,
        Condition = hour.Condition.CreateDto(),
        WindKph = hour.WindKph,
        WindDir = hour.WindDir,
        PressureMb = hour.PressureMb,
        PressureIn = hour.PressureIn,
        PrecipMm = hour.PrecipMm,
        Humidity = hour.Humidity,
        Cloud = hour.Cloud,
        FeelslikeC = hour.FeelslikeC,
        WillItRain = hour.WillItRain is 1,
        ChanceOfRain = hour.ChanceOfRain,
        WillItSnow = hour.WillItSnow is 1,
        ChanceOfSnow = hour.ChanceOfSnow,
        VisibleKm = hour.VisKm,
        GustKph = hour.GustKph,
        Uv = hour.Uv
    };

    private static Condition CreateDto(this IO.Swagger.Model.ForecastCondition condition) => new()
    {
        Text = condition.Text,
        Icon = condition.Icon,
        Code = condition.Code
    };

    private static ForecastDailyWeather CreateDto(this IO.Swagger.Model.ForecastDay daily) => new()
    {
        MaxtempC = daily.MaxtempC,
        MintempC = daily.MintempC,
        AvgtempC = daily.AvgtempC,
        MaxwindKph = daily.MaxwindKph,
        TotalprecipMm = daily.TotalprecipMm,
        AvgvisKm = daily.AvgvisKm,
        Avghumidity = daily.Avghumidity,
        WillItRain = daily.DailyWillItRain is 1,
        ChanceOfRain = daily.DailyChanceOfRain,
        WillItSnow = daily.DailyWillItSnow is 1,
        ChanceOfSnow = daily.DailyChanceOfSnow,
        Condition = daily.Condition.CreateDto(),
        Uv = daily.Uv
    };

    private static Condition CreateDto(this IO.Swagger.Model.ForecastDayCondition condition) => new()
    {
        Text = condition.Text,
        Icon = condition.Icon,
        Code = condition.Code
    };
}
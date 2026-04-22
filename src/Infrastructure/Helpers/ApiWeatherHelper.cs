using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Infrastructure.Helpers;

/// <summary>
/// Класс для работы с API погоды
/// </summary>
public static class ApiWeatherHelper
{
    private static readonly JsonSerializerSettings JsonSerializerSettings = new()
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    };


    /// <summary>
    /// Получение объекта Location из ответа
    /// </summary>
    public static IO.Swagger.Model.Location GetLocation(object response)
    {
        ArgumentNullException.ThrowIfNull(response);
        
        var location = ((JObject)response)["location"]
            .ToObject<IO.Swagger.Model.Location>(JsonSerializer.Create(JsonSerializerSettings));
        return location;
    }

    /// <summary>
    /// Получение объекта Current из ответа
    /// </summary>
    public static IO.Swagger.Model.Current GetCurrent(object response)
    {
        ArgumentNullException.ThrowIfNull(response);
        
        var current = ((JObject)response)["current"]
            .ToObject<IO.Swagger.Model.Current>(JsonSerializer.Create(JsonSerializerSettings));
        return current;
    }

    public static IO.Swagger.Model.Forecast GetForecast(object response)
    {
        ArgumentNullException.ThrowIfNull(response);
        
        var forecast = ((JObject)response)["forecast"]
            .ToObject<IO.Swagger.Model.Forecast>(JsonSerializer.Create(JsonSerializerSettings));
        return forecast;
    }
}
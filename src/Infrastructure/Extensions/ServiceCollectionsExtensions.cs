using App.Services.Interfaces;
using Infrastructure.Services.WeatherService;
using Infrastructure.Services.WeatherService.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

/// <summary>
/// Расширение для  <see cref="IServiceCollection"/>
/// </summary>
public static class ServiceCollectionsExtensions
{
    /// <summary>
    /// Добавить зависимости инфраструктурного слоя
    /// </summary>
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IWeatherService, WeatherService>();

        services.Configure<WeatherServiceOptions>(configuration.GetSection(WeatherServiceOptions.Section));
    }
}
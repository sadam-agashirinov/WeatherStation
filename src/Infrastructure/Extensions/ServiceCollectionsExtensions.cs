using App.Services.Interfaces;
using Infrastructure.Services.WeatherService;
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
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService,WeatherService>();
    }
}
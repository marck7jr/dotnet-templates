using Project1.Application.Interfaces;
using Project1.Infrastructure.Services;

namespace Project1.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // TODO: Register services from Infrastructure layer.
        services.AddTransient<IDateTimeService, DateTimeService>();

        return services;
    }
}
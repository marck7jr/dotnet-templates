using Project1.Application.Interfaces;
using Project1.Infrastructure.Services;

namespace Project1.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // TODO: Register services from Infrastructure layer.
#if (includeDefaultFiles)        
        services.AddTransient<IDateTimeService, DateTimeService>();
#endif
        return services;
    }
}
using Project1.Application.Interfaces;
using Project1.Infrastructure.Services;

namespace Project1.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProject1Infrastructure(this IServiceCollection services)
    {
        // TODO: Register services from Project1 Infrastructure
        services.AddTransient<IDateTimeService, DateTimeService>();

        return services;
    }
}
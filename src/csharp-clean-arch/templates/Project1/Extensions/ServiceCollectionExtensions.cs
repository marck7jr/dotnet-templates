using Project1.Application.Extensions;
using Project1.Domain.Extensions;
using Project1.Infrastructure.Extensions;

namespace Microsoft.Extensions.DependencyInjection;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProject1(this IServiceCollection services)
    {
        // TODO: Register services from all projects of Project1
        services.AddProject1Domain();
        services.AddProject1Application();
        services.AddProject1Infrastructure();

        return services;
    }
}
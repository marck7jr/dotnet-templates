using Project1.Application.Extensions;
using Project1.Domain.Extensions;
using Project1.Infrastructure.Extensions;
#if (includePersistenceProjects)
using Project1.Infrastructure.Persistence.Extensions;
#endif

namespace Microsoft.Extensions.DependencyInjection;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProject1(this IServiceCollection services)
    {
        // TODO: Register services from all projects of Project1ShortName.
        services.AddDomain();
        services.AddApplication();
        services.AddInfrastructure();
#if (includePersistenceProjects)
        services.AddPersistence();
#endif

        return services;
    }
}
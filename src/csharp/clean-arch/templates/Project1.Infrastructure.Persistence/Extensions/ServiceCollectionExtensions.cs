namespace Project1.Infrastructure.Persistence.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        // TODO: Register services from Infrastructure Persistence layer.
        services.AddDbContext<Project1DbContext>(options => 
        {

        });

        return services;
    }
}
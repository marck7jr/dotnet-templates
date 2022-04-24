namespace Project1.Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProject1Application(this IServiceCollection services)
    {
        // TODO: Register services from Project1 Application
        services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
        services.AddValidatorsFromAssembly(typeof(ServiceCollectionExtensions).Assembly);

        return services;
    }
}
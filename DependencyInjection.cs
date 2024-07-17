namespace PX_API;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
        
        //services.AddValidatorsFromAssemblyContaining()

        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddScoped<IDomainEventService, DomainEventService>();

        //services.AddTransient<IDateTime, DateTimeService>();
        //services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

        //services.AddSingleton<ICurrentUserService, CurrentUserService>();

        return services;
    }
}
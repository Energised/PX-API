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

            //options.AddOpenBehavior(typeof(AuthorizationBehaviour<,>));
            //options.AddOpenBehavior(typeof(ValidationBehaviour<,>));
            //options.AddOpenBehavior(typeof(PerformanceBehaviour<,>));
            //options.AddOpenBehavior(typeof(UnhandledExceptionBehaviour<,>));
        });

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // TODO: May look into when adding persistence
        // if (configuration.GetValue<bool>("UseInMemoryDatabase"))
        // {
        //     services.AddDbContext<ApplicationDbContext>(options =>
        //         options.UseInMemoryDatabase("VerticalSliceDb"));
        // }
        // else
        // {
        //     services.AddDbContext<ApplicationDbContext>(options =>
        //         options.UseSqlServer(
        //             configuration.GetConnectionString("DefaultConnection"),
        //             b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        // }

        //services.AddScoped<IDomainEventService, DomainEventService>();

        //services.AddTransient<IDateTime, DateTimeService>();
        //services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

        //services.AddSingleton<ICurrentUserService, CurrentUserService>();

        return services;
    }
}
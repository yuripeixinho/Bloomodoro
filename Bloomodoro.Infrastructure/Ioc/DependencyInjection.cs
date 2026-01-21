using Bloomodoro.Application.Common.Interfaces.Repositories;
using Bloomodoro.Infrastructure.Data.Context;
using Bloomodoro.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bloomodoro.Infrastructure.Ioc;

public static class DependencyInjection
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BloomodoroContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(BloomodoroContext).Assembly.FullName)
            );
        });

        // Repositories
        services.AddScoped<IPlantRepository, PlantRepository>();

        // MediatR
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.Load("Bloomodoro.Application"))
        );

        return services;
    }
}

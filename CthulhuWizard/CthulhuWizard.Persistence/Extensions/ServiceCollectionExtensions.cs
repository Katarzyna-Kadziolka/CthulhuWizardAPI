using CthulhuWizard.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CthulhuWizard.Persistence.Extensions; 

public static class ServiceCollectionExtensions {
    public static void AddRavenDbContext(this IServiceCollection services) {
        services.AddSingleton<IRavenDbContext, RavenDbContext>();
    }

    public static void AddIdentityDbContext(this IServiceCollection services, IConfiguration configuration,
        IHostEnvironment hostEnvironment) {
        string connectionString;
        if (hostEnvironment.IsProduction()) {
            connectionString = new HerokuDbConnector.HerokuDbConnector().Build();
        }
        else {
            connectionString = configuration.GetConnectionString("Default");
        }
        services.AddDbContext<IdentityDbContext>(options => options.UseNpgsql(connectionString));
    }
}

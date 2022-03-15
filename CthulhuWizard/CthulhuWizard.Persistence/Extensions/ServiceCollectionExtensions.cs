using CthulhuWizard.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CthulhuWizard.Persistence.Extensions; 

public static class ServiceCollectionExtensions {
    public static void AddRavenDbContext(this IServiceCollection services) {
        services.AddSingleton<IRavenDbContext, RavenDbContext>();
    }

    public static void AddIdentityDbContext(this IServiceCollection services, string connectionString) {
        services.AddDbContext<IdentityDbContext>(options => options.UseNpgsql(connectionString));
    }
}
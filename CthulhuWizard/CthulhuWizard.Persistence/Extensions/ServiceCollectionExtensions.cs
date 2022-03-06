using CthulhuWizard.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace CthulhuWizard.Persistence.Extensions; 

public static class ServiceCollectionExtensions {
    public static void AddRavenDbContext(this IServiceCollection services) {
        services.AddSingleton<IRavenDbContext, RavenDbContext>();
    }
}
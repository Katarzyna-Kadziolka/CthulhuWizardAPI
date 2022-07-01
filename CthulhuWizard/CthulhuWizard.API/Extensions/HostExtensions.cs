using CthulhuWizard.Persistence;
using CthulhuWizard.Persistence.Contexts;

namespace CthulhuWizard.API.Extensions; 

public static class HostExtensions {
    public static IHost Seed(this IHost host) {
        var logger = host.Services.GetRequiredService<ILogger<Seeder>>();
        logger.LogDebug("Start seeding ravenDb");
        var context = host.Services.GetRequiredService<IRavenDbContext>();
        var seeder = new Seeder(context);
        seeder.SeedDefaultData();
        logger.LogDebug("RavenDb is seeded");
        return host;
    }
}
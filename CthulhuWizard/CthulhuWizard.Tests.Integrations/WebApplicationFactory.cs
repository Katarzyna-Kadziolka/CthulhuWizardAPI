using System;
using System.Linq;
using CthulhuWizard.API;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Tests.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CthulhuWiard.Tests.Integrations;

public class WebApplicationFactory : WebApplicationFactory<Startup> {
    // podmień mój RavenDbContext na TestRavenDbContext
    protected override void ConfigureWebHost(IWebHostBuilder builder) {
        builder.ConfigureServices(services => {
            var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(IRavenDbContext));
            if (descriptor != null) {
                services.Remove(descriptor);
                services.AddSingleton<IRavenDbContext, RavenTestDb>();
            }
        });
    }
}
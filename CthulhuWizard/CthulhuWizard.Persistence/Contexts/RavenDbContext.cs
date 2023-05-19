using System.Security.Cryptography.X509Certificates;
using CthulhuWizard.Persistence.Options;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using Raven.Client.Documents.Operations;
using Raven.Client.Exceptions.Database;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;

namespace CthulhuWizard.Persistence.Contexts;

public class RavenDbContext : IRavenDbContext {
    private readonly RavenDbOptions _options;

    public RavenDbContext(IOptions<RavenDbOptions> options, IHostEnvironment environment) {
        X509Certificate2? clientCertificate = null;
        if (environment.IsProduction()) {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Auth", "Production.pfx");
            clientCertificate = new X509Certificate2(path, Environment.GetEnvironmentVariable("RAVENDB_CERT_PASSWORD"));
        }

        _options = options.Value;
        Store = new DocumentStore() {
            Database = _options.DatabaseName,
            Urls = _options.Urls,
            Certificate = clientCertificate
        };
        Store.Initialize();
        EnsureDatabaseIsCreated();
    }
    
    public IDocumentStore Store { get; }

    public void EnsureDatabaseIsCreated() {
        try {
            Store.Maintenance.ForDatabase(_options.DatabaseName).Send(new GetStatisticsOperation());
        }
        catch (DatabaseDoesNotExistException) {
            Store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(_options.DatabaseName)));
        }
    }
}

using CthulhuWizard.Persistence.Options;
using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using Raven.Client.Documents.Operations;
using Raven.Client.Exceptions.Database;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;

namespace CthulhuWizard.Persistence.Contexts;

public class RavenDbContext : IRavenDbContext {
    private readonly RavenDbOptions _options;

    public RavenDbContext(IOptions<RavenDbOptions> options) {
        _options = options.Value;
        Store = new DocumentStore() {
            Database = _options.DatabaseName,
            Urls = _options.Urls
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
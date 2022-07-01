using CthulhuWizard.Persistence;
using CthulhuWizard.Persistence.Contexts;
using Raven.Client.Documents;
using Raven.TestDriver;

namespace CthulhuWizard.Tests.Shared;

public class RavenTestDb : RavenTestDriver, IRavenDbContext {
    private IDocumentStore? _store;

    public RavenTestDb() {
        var seeder = new Seeder(this);
        seeder.SeedDefaultData();
    }

    protected override void PreInitialize(IDocumentStore documentStore) {
        documentStore.Conventions.MaxNumberOfRequestsPerSession = 50;
    }

    public void WaitForUserToContinueTheTest() => WaitForUserToContinueTheTest(Store);

    public IDocumentStore Store {
        get {
            if (_store is null) {
                _store = GetDocumentStore();
            }

            return _store;
        }
    }

    public void WaitForIndexing() => WaitForIndexing(Store);
}
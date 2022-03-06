using Raven.Client.Documents;

namespace CthulhuWizard.Persistence.Contexts;

public class RavenDbContext : IRavenDbContext {
    public IDocumentStore Store { get; set; }
}
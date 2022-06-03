using Raven.Client.Documents;

namespace CthulhuWizard.Persistence.Contexts; 

public interface IRavenDbContext {
    public IDocumentStore Store { get; }
}
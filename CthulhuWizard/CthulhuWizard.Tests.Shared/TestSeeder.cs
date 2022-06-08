using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;

namespace CthulhuWizard.Tests.Shared; 

public class TestSeeder {
    private readonly IRavenDbContext _context;

    public TestSeeder(IRavenDbContext context) {
        _context = context;
    }

    public TestSeeder AddInvestigator() {
        using var session = _context.Store.OpenSession();
        foreach (var investigator in new InvestigatorEntityGenerator().Generate(10)) {
           session.Store(investigator); 
        }
        session.SaveChanges();
        return this;
    }
}
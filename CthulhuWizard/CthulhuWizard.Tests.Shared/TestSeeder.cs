using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared.Generators;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;

namespace CthulhuWizard.Tests.Shared; 

public class TestSeeder {
    private readonly IRavenDbContext _context;

    public TestSeeder(IRavenDbContext context) {
        _context = context;
    }

    public TestSeeder AddInvestigators() {
        using var session = _context.Store.OpenSession();
        foreach (var investigator in new InvestigatorEntityGenerator().Generate(10)) {
           session.Store(investigator); 
        }
        session.SaveChanges();
        return this;
    }
    public TestSeeder AddEquipments() {
        using var session = _context.Store.OpenSession();
        foreach (var equipment in new EquipmentEntityGenerator().Generate(10)) {
            session.Store(equipment); 
        }
        session.SaveChanges();
        return this;
    }
    public TestSeeder AddOccupations() {
        using var session = _context.Store.OpenSession();
        foreach (var occupation in new OccupationEntityGenerator().Generate(10)) {
            session.Store(occupation); 
        }
        session.SaveChanges();
        return this;
    }
}


using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators; 

public sealed class InvestigatorSkillEntityGenerator: Faker<InvestigatorSkillEntity>  {
    public InvestigatorSkillEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.CurrentValue, f => f.Random.Int(15, 80))
            .Generate(10);
    }
}
using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Tests.Shared.Generators; 

public sealed class OccupationSkillSpecificationEntityGenerator : Faker<OccupationSkillSpecificationEntity> {
    public OccupationSkillSpecificationEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.HowMany, f => f.Random.Int(1, 2))
            .RuleFor(a => a.From, f => new List<string> { f.Lorem.Word() });
    }
}
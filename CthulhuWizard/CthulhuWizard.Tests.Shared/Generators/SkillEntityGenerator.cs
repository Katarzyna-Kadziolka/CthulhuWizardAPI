using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class SkillEntityGenerator : Faker<SkillEntity> {
    public SkillEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.MinValue, f => f.Random.Int(0, 15))
            .Generate(10);
    }
}
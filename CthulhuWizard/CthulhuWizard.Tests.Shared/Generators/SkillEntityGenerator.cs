using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class SkillEntityGenerator : Faker<SkillEntity> {
    public SkillEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid().ToString())
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.IsRare, f => f.Random.Bool())
            .RuleFor(a => a.MinValue, f => f.Random.Int(0, 15))
            .RuleFor(a => a.CurrentValue, f => f.Random.Int(16, 99))
            .Generate(10);
    }
}
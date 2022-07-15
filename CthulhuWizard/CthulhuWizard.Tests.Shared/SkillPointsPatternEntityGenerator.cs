using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared; 

public sealed class SkillPointsPatternEntityGenerator : Faker<SkillPointsPatternEntity> {
    public SkillPointsPatternEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Multiplier, f => f.Random.Int(2, 4))
            .RuleFor(a => a.PossibleAttributes, f => new List<string> { f.Lorem.Word() });
    }
}
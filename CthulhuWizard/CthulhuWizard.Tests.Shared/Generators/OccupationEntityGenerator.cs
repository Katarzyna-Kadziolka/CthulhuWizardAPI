using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class OccupationEntityGenerator : Faker<OccupationEntity> {
    public OccupationEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid().ToString())
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.ImageUrl, f => f.Internet.Url())
            .RuleFor(a => a.Descritpion, f => f.Lorem.Paragraph())
            .RuleFor(a => a.IsLovecraftian, f => f.Random.Bool())
            .RuleFor(a => a.SkillPoints, f => f.Random.Int(15, 99))
            .RuleFor(a => a.MinCreditRating, f => f.Random.Int(15, 30))
            .RuleFor(a => a.MaxCreditRating, f => f.Random.Int(31, 99))
            .RuleFor(a => a.Skills,
                new List<OccupationSkillSpecificationEntity> {
                    new OccupationSkillSpecificationEntityGenerator().Generate()
                })
            .RuleFor(a => a.SkillPointsPattern,
                new List<SkillPointsPatternEntity> { new SkillPointsPatternEntityGenerator().Generate() })
            .RuleFor(a => a.SuggestedContacts, f => f.Lorem.Sentence());
    }
}

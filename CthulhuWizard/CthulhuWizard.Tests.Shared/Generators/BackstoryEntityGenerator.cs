using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class BackstoryEntityGenerator : Faker<BackstoryEntity> {
    public BackstoryEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Traits, f => f.Lorem.Sentence())
            .RuleFor(a => a.IdeologyBeliefs, f => f.Lorem.Sentence())
            .RuleFor(a => a.InjuriesScars, f => f.Lorem.Sentence())
            .RuleFor(a => a.MeaningfulLocations, f => f.Lorem.Sentence())
            .RuleFor(a => a.PersonalDescription, f => f.Lorem.Sentence())
            .RuleFor(a => a.PhobiasManias, f => f.Lorem.Sentence())
            .RuleFor(a => a.SignificantPeople, f => f.Lorem.Sentence())
            .RuleFor(a => a.TreasuredPossessions, f => f.Lorem.Sentence())
            .RuleFor(a => a.ArcaneTomesSpellsArtifacts, f => f.Lorem.Sentence())
            .RuleFor(a => a.EncountersWithStrangeEntities, f => f.Lorem.Sentence());
    }
}
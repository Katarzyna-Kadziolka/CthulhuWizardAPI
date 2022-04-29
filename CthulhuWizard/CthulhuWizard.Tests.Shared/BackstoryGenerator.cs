using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class BackstoryGenerator {
	public static BackstoryEntity BackstoryEntity { get; set; }

	static BackstoryGenerator() {
		BackstoryEntity = new Faker<BackstoryEntity>()
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
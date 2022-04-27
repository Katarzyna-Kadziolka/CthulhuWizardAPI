using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class BackstoryGenerator {
	public static Backstory Backstory { get; set; }

	static BackstoryGenerator() {
		Backstory = new Faker<Backstory>()
		            .RuleFor(a => a.Traits, f => f.Lorem.Sentence())
		            .RuleFor(a => a.IdeologyBeliefs, f => f.Lorem.Sentence())
		            .RuleFor(a => a.InjuriesScars, f => f.Lorem.Sentence())
		            .RuleFor(a => a.MeaningfulLocations, f => f.Lorem.Sentence())
		            .RuleFor(a => a.PersonalDescription, f => f.Lorem.Sentence())
		            .RuleFor(a => a.PhobiasManias, f => f.Lorem.Sentence())
		            .RuleFor(a => a.SignificantPeople, f => f.Lorem.Sentence())
		            .RuleFor(a => a.TreasuredPossessions, f => f.Lorem.Sentence())
		            .RuleFor(a => a.ArcaneTomesSpellsAtifacts, f => f.Lorem.Sentence())
		            .RuleFor(a => a.EncountersWithStrangeEntities, f => f.Lorem.Sentence());
	}
}
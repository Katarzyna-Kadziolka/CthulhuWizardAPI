using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class OccupationGenerator {
	public static Occupation Occupation { get; set; }

	static OccupationGenerator() {
		Occupation = new Faker<Occupation>()
		             .RuleFor(a => a.Id, f => Guid.NewGuid())
		             .RuleFor(a => a.Name, f => f.Lorem.Word())
		             .RuleFor(a => a.ImageUrl, f => f.Internet.Url())
		             .RuleFor(a => a.Descritpion, f => f.Lorem.Paragraph())
		             .RuleFor(a => a.IsLovecraftian, f => f.Random.Bool())
		             .RuleFor(a => a.SkillPoints, f => f.Random.Int(15, 99))
		             .RuleFor(a => a.MinCreditRating, f => f.Random.Int(15, 30))
		             .RuleFor(a => a.MaxCreditRating, f => f.Random.Int(31, 99))
		             .RuleFor(a => a.Skills, f => new List<Skill>{SkillGenerator.Skill});
	}
}
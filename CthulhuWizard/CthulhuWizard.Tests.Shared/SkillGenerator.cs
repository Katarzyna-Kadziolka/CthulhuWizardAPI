using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared; 

public static class SkillGenerator {
	public static Skill Skill { get; set; }

	static SkillGenerator() {
		Skill = new Faker<Skill>()
		         .RuleFor(a => a.Id, f => Guid.NewGuid())
		         .RuleFor(a => a.Name, f => f.Lorem.Word())
		         .RuleFor(a => a.IsRare, f => f.Random.Bool())
		         .RuleFor(a => a.MinValue, f => f.Random.Int(0, 99))
		         .RuleFor(a => a.Occupations, f => new List<Occupation>());
	}
}
using Bogus;
using CthulhuWizard.Persistence.Models;
using Raven.Client.Documents.Linq;

namespace CthulhuWizard.Tests.Shared; 

public static class SkillsGenerator {
	public static List<Skill> Skills { get; set; }

	static SkillsGenerator() {
		Skills = new Faker<Skill>()
		         .RuleFor(a => a.Id, f => Guid.NewGuid())
		         .RuleFor(a => a.Name, f => f.Lorem.Word())
		         .RuleFor(a => a.IsRare, f => f.Random.Bool())
		         .RuleFor(a => a.MinValue, f => f.Random.Int(0, 15))
		         .RuleFor(a => a.CurrentValue, f => f.Random.Int(16, 99))
		         .Generate(10);
	}
}
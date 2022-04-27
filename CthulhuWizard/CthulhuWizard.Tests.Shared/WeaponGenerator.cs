using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class WeaponGenerator {
	public static Weapon Weapon { get; set; }

	static WeaponGenerator() {
		Weapon = new Faker<Weapon>()
		          .RuleFor(a => a.Id, f => Guid.NewGuid())
		          .RuleFor(a => a.Name, f => f.Lorem.Word())
		          .RuleFor(a => a.Skill, f => SkillGenerator.Skill)
		          .RuleFor(a => a.IsImpale, f => f.Random.Bool())
		          .RuleFor(a => a.Damage, f => f.Lorem.Sentence())
		          .RuleFor(a => a.BaseRange, f => f.Lorem.Sentence())
		          .RuleFor(a => a.UsesPerRound, f => f.Lorem.Sentence())
		          .RuleFor(a => a.BulletsInGun, f => f.Lorem.Sentence())
		          .RuleFor(a => a.Cost, f => f.Random.Int(1, 10000))
		          .RuleFor(a => a.Malfunction, f => f.Finance.Amount())
		          .RuleFor(a => a.Investigators, f => new List<Investigator>());

	}
}
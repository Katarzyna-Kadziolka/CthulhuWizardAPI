using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared; 

public static class WeaponsGenerator {
	public static List<WeaponEntity> Weapons { get; set; }

	static WeaponsGenerator() {
		Weapons = new Faker<WeaponEntity>()
		         .RuleFor(a => a.Id, _ => Guid.NewGuid())
		         .RuleFor(a => a.Name, f => f.Lorem.Word())
		         .RuleFor(a => a.SkillEntity, _ => SkillsGenerator.Skills.First())
		         .RuleFor(a => a.IsImpale, f => f.Random.Bool())
		         .RuleFor(a => a.Damage, f => f.Lorem.Sentence())
		         .RuleFor(a => a.BaseRange, f => f.Lorem.Sentence())
		         .RuleFor(a => a.UsesPerRound, f => f.Lorem.Sentence())
		         .RuleFor(a => a.BulletsInGun, f => f.Lorem.Sentence())
		         .RuleFor(a => a.Cost, f => f.Random.Int(1, 10000))
		         .RuleFor(a => a.Malfunction, f =>Convert.ToInt32(f.Finance.Amount()))
		         .Generate(10);

	}
}
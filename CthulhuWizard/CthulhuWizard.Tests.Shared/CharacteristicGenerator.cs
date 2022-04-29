using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class CharacteristicGenerator {
	public static CharacteristicEntity CharacteristicEntity { get; set; }

	static CharacteristicGenerator() {
		CharacteristicEntity = new Faker<CharacteristicEntity>()
		                 .RuleFor(a => a.Appearance, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Build, f => f.PickRandom<Build>())
		                 .RuleFor(a => a.Constitution, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Dexterity, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Education, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Intelligence, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Luck, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Power, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Size, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.Strength, f => f.Random.Int(15, 99))
		                 .RuleFor(a => a.DamageBonus, f => f.PickRandom<DamageBonus>())
		                 .RuleFor(a => a.HitPoints, f => f.Random.Int(0, 20))
		                 .RuleFor(a => a.MovementRate, f => f.Random.Int(0, 10));
	}
}
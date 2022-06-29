using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class CharacteristicEntityGenerator : Faker<CharacteristicEntity> {
    public CharacteristicEntityGenerator() {
        StrictMode(true)
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
            .RuleFor(a => a.MovementRate, f => f.Random.Int(0, 10))
            .RuleFor(a => a.MagicPoints, f => f.Random.Int(15, 99))
            .RuleFor(a => a.Sanity, f => f.Random.Int(15, 99));
    }
}
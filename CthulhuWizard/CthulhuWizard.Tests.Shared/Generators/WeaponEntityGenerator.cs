using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class WeaponEntityGenerator : Faker<WeaponEntity> {
    public WeaponEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid().ToString())
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.Skill, f => f.Lorem.Word())
            .RuleFor(a => a.IsImpale, f => f.Random.Bool())
            .RuleFor(a => a.Damage, f => f.Lorem.Sentence())
            .RuleFor(a => a.BaseRange, f => f.Lorem.Sentence())
            .RuleFor(a => a.UsesPerRound, f => f.Lorem.Sentence())
            .RuleFor(a => a.BulletsInGun, f => f.Lorem.Sentence())
            .RuleFor(a => a.Cost, f => Convert.ToDouble(f.Finance.Amount()))
            .RuleFor(a => a.Malfunction, f => f.Random.Int(1, 99));
    }
}

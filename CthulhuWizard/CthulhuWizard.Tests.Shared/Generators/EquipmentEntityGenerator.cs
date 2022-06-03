using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class EquipmentEntityGenerator : Faker<EquipmentEntity> {
    public EquipmentEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid())
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.Price, f => Convert.ToInt32(f.Finance.Amount()))
            .Generate(10);
    }
}
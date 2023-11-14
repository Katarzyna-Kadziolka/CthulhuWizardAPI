using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class EquipmentEntityGenerator : Faker<EquipmentEntity> {
    public EquipmentEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid().ToString())
            .RuleFor(a => a.Name, f => f.Lorem.Word())
            .RuleFor(a => a.Price, f => Convert.ToDouble(f.Finance.Amount()))
            .RuleFor(a => a.Type, f => f.Lorem.Word());
    }
}

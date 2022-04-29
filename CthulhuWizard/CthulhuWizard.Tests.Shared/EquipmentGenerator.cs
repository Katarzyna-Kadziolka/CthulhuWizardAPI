using Bogus;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Tests.Shared; 

public static class EquipmentGenerator {
	public static List<EquipmentEntity> Equipments { get; set; }

	static EquipmentGenerator() {
		Equipments = new Faker<EquipmentEntity>()
		            .RuleFor(a => a.Id, _ => Guid.NewGuid())
		            .RuleFor(a => a.Name, f => f.Lorem.Word())
		            .RuleFor(a => a.Price, f => Convert.ToInt32(f.Finance.Amount()))
		            .Generate(10);
	}
}
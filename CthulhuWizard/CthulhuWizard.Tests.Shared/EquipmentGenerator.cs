using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class EquipmentGenerator {
	public static List<Equipment> Equipments { get; set; }

	static EquipmentGenerator() {
		Equipments = new Faker<Equipment>()
		            .RuleFor(a => a.Id, f => Guid.NewGuid())
		            .RuleFor(a => a.Name, f => f.Lorem.Word())
		            .RuleFor(a => a.Price, f => Convert.ToInt32(f.Finance.Amount()))
		            .Generate(10);
	}
}
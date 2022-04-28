using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class EquipmentGenerator {
	public static Equipment Equipment { get; set; }

	static EquipmentGenerator() {
		Equipment = new Faker<Equipment>()
		            .RuleFor(a => a.Id, f => Guid.NewGuid())
		            .RuleFor(a => a.Name, f => f.Lorem.Word())
		            .RuleFor(a => a.Price, f => f.Finance.Amount());
	}
}
using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class EquipmentsGenerator {
	public static List<Equipment> Equipment { get; set; }

	static EquipmentsGenerator() {
		Equipment = new Faker<Equipment>()
		            .RuleFor(a => a.Id, f => Guid.NewGuid())
		            .RuleFor(a => a.Name, f => f.Lorem.Word())
		            .RuleFor(a => a.Price, f => f.Finance.Amount())
		            .RuleFor(a => a.Investigators, f => new List<Investigator>())
		            .Generate(10);
	}
}
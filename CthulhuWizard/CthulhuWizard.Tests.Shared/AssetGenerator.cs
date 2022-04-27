using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared;

public static class AssetGenerator {
	public static Asset Asset { get; set; }
	static AssetGenerator() {
		Asset = new Faker<Asset>()
		        .RuleFor(a => a.Assets, f => f.Finance.Amount())
		        .RuleFor(a => a.Cash, f => f.Finance.Amount())
		        .RuleFor(a => a.SpendingLevel, f => f.Finance.Amount());
	}
}
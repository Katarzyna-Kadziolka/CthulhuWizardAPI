using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared;

public static class AssetGenerator {
	public static Asset Asset { get; set; }
	static AssetGenerator() {
		Asset = new Faker<Asset>()
		        .RuleFor(a => a.Assets, f => Convert.ToInt32(f.Finance.Amount()))
		        .RuleFor(a => a.Cash, f => Convert.ToInt32(f.Finance.Amount()))
		        .RuleFor(a => a.SpendingLevel, f => Convert.ToInt32(f.Finance.Amount()));
	}
}
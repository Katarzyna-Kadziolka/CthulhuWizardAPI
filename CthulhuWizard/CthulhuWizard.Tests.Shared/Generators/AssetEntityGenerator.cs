using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators;

public sealed class AssetEntityGenerator: Faker<AssetEntity> {
	public AssetEntityGenerator() {
		StrictMode(true)
		        .RuleFor(a => a.Assets, f => Convert.ToInt32(f.Finance.Amount()))
		        .RuleFor(a => a.Cash, f => Convert.ToInt32(f.Finance.Amount()))
		        .RuleFor(a => a.SpendingLevel, f => Convert.ToInt32(f.Finance.Amount()));
	}
}
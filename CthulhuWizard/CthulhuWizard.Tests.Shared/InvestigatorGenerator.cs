using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class InvestigatorGenerator {
	public static Investigator Investigator { get; set; }

	static InvestigatorGenerator() {
		Investigator = new Faker<Investigator>()
		               .RuleFor(a => a.Id, f => Guid.NewGuid())
		               .RuleFor(a => a.FirstName, f => f.Person.FirstName)
		               .RuleFor(a => a.LastName, f => f.Person.LastName)
		               .RuleFor(a => a.Age, f => f.Random.Int(15, 90))
		               .RuleFor(a => a.Gender, f => f.PickRandom<Gender>())
		               .RuleFor(a => a.BirthPlace, f => f.Address.City())
		               .RuleFor(a => a.Residence, f => f.Address.City())
		               .RuleFor(a => a.Occupation, f => OccupationGenerator.Occupation)
		               .RuleFor(a => a.Characteristic, f => CharacteristicGenerator.Characteristic)
		               .RuleFor(a => a.Skills, f => SkillsGenerator.Skills)
		               .RuleFor(a => a.Weapons, f => WeaponsGenerator.Weapons)
		               .RuleFor(a => a.Equipments, f => EquipmentsGenerator.Equipment)
		               .RuleFor(a => a.Asset, f => AssetGenerator.Asset)
		               .RuleFor(a => a.Backstory, f => BackstoryGenerator.Backstory);
	}
}
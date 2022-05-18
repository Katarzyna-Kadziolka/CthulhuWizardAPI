using Bogus;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared; 

public static class InvestigatorGenerator {
	public static InvestigatorEntity InvestigatorEntity { get; set; }

	static InvestigatorGenerator() {
		InvestigatorEntity = new Faker<InvestigatorEntity>()
		               .RuleFor(a => a.Id, _ => Guid.NewGuid())
		               .RuleFor(a => a.FirstName, f => f.Person.FirstName)
		               .RuleFor(a => a.LastName, f => f.Person.LastName)
		               .RuleFor(a => a.Age, f => f.Random.Int(15, 90))
		               .RuleFor(a => a.Gender, f => f.PickRandom<Gender>())
		               .RuleFor(a => a.BirthPlace, f => f.Address.City())
		               .RuleFor(a => a.Residence, f => f.Address.City())
		               .RuleFor(a => a.Occupation, _ => OccupationsGenerator.Occupations.First())
		               .RuleFor(a => a.Characteristic, _ => CharacteristicGenerator.CharacteristicEntity)
		               .RuleFor(a => a.Skills, SkillsGenerator.Skills)
		               .RuleFor(a => a.Weapons, WeaponsGenerator.Weapons)
		               .RuleFor(a => a.Equipments, _ => EquipmentGenerator.Equipments)
		               .RuleFor(a => a.Asset, _ => AssetGenerator.AssetEntity)
		               .RuleFor(a => a.Backstory, _ => BackstoryGenerator.BackstoryEntity);
	}
}
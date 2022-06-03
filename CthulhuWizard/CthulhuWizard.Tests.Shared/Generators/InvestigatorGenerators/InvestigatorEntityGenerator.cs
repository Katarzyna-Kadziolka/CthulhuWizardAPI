using Bogus;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;

public sealed class InvestigatorEntityGenerator : Faker<InvestigatorEntity> {
    public InvestigatorEntityGenerator() {
        StrictMode(true)
            .RuleFor(a => a.Id, _ => Guid.NewGuid().ToString())
            .RuleFor(a => a.FirstName, f => f.Person.FirstName)
            .RuleFor(a => a.LastName, f => f.Person.LastName)
            .RuleFor(a => a.Age, f => f.Random.Int(15, 90))
            .RuleFor(a => a.Gender, f => f.PickRandom<Gender>())
            .RuleFor(a => a.BirthPlace, f => f.Address.City())
            .RuleFor(a => a.Residence, f => f.Address.City())
            .RuleFor(a => a.Occupation, _ => new OccupationEntityGenerator().Generate())
            .RuleFor(a => a.Characteristic, _ => new CharacteristicEntityGenerator().Generate())
            .RuleFor(a => a.Skills, new List<SkillEntity> { new SkillEntityGenerator().Generate() })
            .RuleFor(a => a.Weapons, new List<WeaponEntity>{new WeaponEntityGenerator().Generate()})
            .RuleFor(a => a.Equipments, _ => new List<EquipmentEntity> { new EquipmentEntityGenerator().Generate() })
            .RuleFor(a => a.Asset, _ => new AssetEntityGenerator().Generate())
            .RuleFor(a => a.Backstory, _ => new BackstoryEntityGenerator().Generate());
    }
}
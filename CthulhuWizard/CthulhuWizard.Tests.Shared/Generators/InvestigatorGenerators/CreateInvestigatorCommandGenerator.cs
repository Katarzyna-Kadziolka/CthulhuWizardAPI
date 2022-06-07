using Bogus;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;

public sealed class CreateInvestigatorCommandGenerator : Faker<CreateInvestigatorCommand> {
    public CreateInvestigatorCommandGenerator() {
        StrictMode(true)
            .RuleFor(a => a.FirstName, f => f.Person.FirstName)
            .RuleFor(a => a.LastName, f => f.Person.LastName)
            .RuleFor(a => a.Age, f => f.Random.Int(15, 90))
            .RuleFor(a => a.Gender, f => f.PickRandom<Gender>())
            .RuleFor(a => a.BirthPlace, f => f.Address.City())
            .RuleFor(a => a.Residence, f => f.Address.City())
            .RuleFor(a => a.Occupation,
                f => TestMapper.Instance.Map<OccupationDto>(new OccupationEntityGenerator().Generate()))
            .RuleFor(a => a.Characteristic,
                _ => TestMapper.Instance.Map<CharacteristicDto>(new CharacteristicEntityGenerator().Generate()))
            .RuleFor(a => a.Skills, new SkillEntityGenerator().Generate(1))
            .RuleFor(a => a.Weapons, new WeaponEntityGenerator().Generate(1))
            .RuleFor(a => a.Equipments, _ => new EquipmentEntityGenerator().Generate(1))
            .RuleFor(a => a.Asset, 
                _ => TestMapper.Instance.Map<AssetDto>(new AssetEntityGenerator().Generate()))
            .RuleFor(a => a.Backstory,
                _ => TestMapper.Instance.Map<BackstoryDto>(new BackstoryEntityGenerator().Generate()))
            .RuleFor(a => a.ImageUrl, f => f.Internet.Url());
    }
}
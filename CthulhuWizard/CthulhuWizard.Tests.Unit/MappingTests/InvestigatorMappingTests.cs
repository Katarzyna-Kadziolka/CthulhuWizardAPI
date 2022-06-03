using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class InvestigatorMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_InvestigatorEntity_ShouldReturnInvestigatorDto() {
        // Arrange
        var generator = new InvestigatorEntityGenerator();
        var investigator = generator.Generate();
        // Act
        var investigatorDto = _mapper.Map<InvestigatorDto>(investigator);
        // Assert
        investigatorDto.Age.Should().Be(investigator.Age);
        investigatorDto.Id.Should().Be(investigator.Id);
        investigatorDto.Asset.Should().BeEquivalentTo(investigator.Asset);
        investigatorDto.Skills.Should().BeEquivalentTo(investigator.Skills);
        investigatorDto.Backstory.Should().BeEquivalentTo(investigator.Backstory);
        investigatorDto.Characteristic.Should().BeEquivalentTo(investigator.Characteristic);
        investigatorDto.Gender.Should().Be(investigator.Gender);
        investigatorDto.Occupation.Should().BeEquivalentTo(investigator.Occupation);
        investigatorDto.Residence.Should().Be(investigator.Residence);
        investigatorDto.BirthPlace.Should().Be(investigator.BirthPlace);
        investigatorDto.FirstName.Should().Be(investigator.FirstName);
        investigatorDto.LastName.Should().Be(investigator.LastName);
        investigatorDto.Equipments.Should().BeEquivalentTo(investigator.Equipments);
        investigatorDto.Skills.Should().BeEquivalentTo(investigator.Skills);
        investigatorDto.Weapons.Should().BeEquivalentTo(investigator.Weapons);
    }
}
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class InvestigatorMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_InvestigatorEntity_ShouldReturnInvestigatorDetailsDto() {
        // Arrange
        var generator = new InvestigatorEntityGenerator();
        var investigator = generator.Generate();
        // Act
        var investigatorDetailsDto = _mapper.Map<InvestigatorDetailsDto>(investigator);
        // Assert
        investigatorDetailsDto.Age.Should().Be(investigator.Age);
        investigatorDetailsDto.Id.Should().Be(investigator.Id);
        investigatorDetailsDto.Asset.Should().BeEquivalentTo(investigator.Asset);
        investigatorDetailsDto.Skills.Should().BeEquivalentTo(investigator.Skills);
        investigatorDetailsDto.Backstory.Should().BeEquivalentTo(investigator.Backstory);
        investigatorDetailsDto.Characteristic.Should().BeEquivalentTo(investigator.Characteristic);
        investigatorDetailsDto.Gender.Should().Be(investigator.Gender);
        investigatorDetailsDto.Occupation.Should().BeEquivalentTo(investigator.Occupation);
        investigatorDetailsDto.Residence.Should().Be(investigator.Residence);
        investigatorDetailsDto.BirthPlace.Should().Be(investigator.BirthPlace);
        investigatorDetailsDto.FirstName.Should().Be(investigator.FirstName);
        investigatorDetailsDto.LastName.Should().Be(investigator.LastName);
        investigatorDetailsDto.Equipments.Should().BeEquivalentTo(investigator.Equipments);
        investigatorDetailsDto.Skills.Should().BeEquivalentTo(investigator.Skills);
        investigatorDetailsDto.Weapons.Should().BeEquivalentTo(investigator.Weapons);
        investigatorDetailsDto.ImageUrl.Should().Be(investigator.ImageUrl);
    }
    [Test]
    public void Map_InvestigatorCommand_ShouldReturnInvestigatorEntity() {
        // Arrange
        var generator = new CreateInvestigatorCommandGenerator();
        var createInvestigatorCommand = generator.Generate();
        // Act
        var investigatorEntity = _mapper.Map<InvestigatorEntity>(createInvestigatorCommand);
        // Assert
        investigatorEntity.Age.Should().Be(createInvestigatorCommand.Age);
        investigatorEntity.Asset.Should().BeEquivalentTo(createInvestigatorCommand.Asset);
        investigatorEntity.Skills.Should().BeEquivalentTo(createInvestigatorCommand.Skills);
        investigatorEntity.Backstory.Should().BeEquivalentTo(createInvestigatorCommand.Backstory);
        investigatorEntity.Characteristic.Should().BeEquivalentTo(createInvestigatorCommand.Characteristic);
        investigatorEntity.Gender.Should().Be(createInvestigatorCommand.Gender);
        investigatorEntity.Occupation.Should().BeEquivalentTo(createInvestigatorCommand.Occupation);
        investigatorEntity.Residence.Should().Be(createInvestigatorCommand.Residence);
        investigatorEntity.BirthPlace.Should().Be(createInvestigatorCommand.BirthPlace);
        investigatorEntity.FirstName.Should().Be(createInvestigatorCommand.FirstName);
        investigatorEntity.LastName.Should().Be(createInvestigatorCommand.LastName);
        investigatorEntity.Equipments.Should().BeEquivalentTo(createInvestigatorCommand.Equipments);
        investigatorEntity.Skills.Should().BeEquivalentTo(createInvestigatorCommand.Skills);
        investigatorEntity.Weapons.Should().BeEquivalentTo(createInvestigatorCommand.Weapons);
        investigatorEntity.ImageUrl.Should().Be(createInvestigatorCommand.ImageUrl);
    }
    [Test]
    public void Map_InvestigatorEntity_ShouldReturnInvestigatorDto() {
        // Arrange
        var generator = new InvestigatorEntityGenerator();
        var investigator = generator.Generate();
        // Act
        var investigatorDto = _mapper.Map<InvestigatorDto>(investigator);
        // Assert
        investigatorDto.Age.Should().Be(investigator.Age);
        investigatorDto.Gender.Should().Be(investigator.Gender);
        investigatorDto.Occupation.Name.Should().Be(investigator.Occupation.Name);
        investigatorDto.FirstName.Should().Be(investigator.FirstName);
        investigatorDto.LastName.Should().Be(investigator.LastName);
        investigatorDto.ImageUrl.Should().Be(investigator.ImageUrl);
    }
}
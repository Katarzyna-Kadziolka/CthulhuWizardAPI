using System.Linq;
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class OccupationMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_OccupationEntity_ShouldReturnOccupationDetailsDto() {
        // Arrange
        var generator = new OccupationEntityGenerator();
        var occupation = generator.Generate();
        // Act
        var occupationDetailsDto = _mapper.Map<OccupationDetailsDto>(occupation);
        // Assert
        occupationDetailsDto.Descritpion.Should().Be(occupation.Descritpion);
        occupationDetailsDto.Id.Should().Be(occupation.Id);
        occupationDetailsDto.Name.Should().Be(occupation.Name);
        occupationDetailsDto.Skills.Should().BeEquivalentTo(occupation.Skills);
        occupationDetailsDto.ImageUrl.Should().Be(occupation.ImageUrl);
        occupationDetailsDto.IsLovecraftian.Should().Be(occupation.IsLovecraftian);
        occupationDetailsDto.SkillPoints.Should().Be(occupation.SkillPoints);
        occupationDetailsDto.MaxCreditRating.Should().Be(occupation.MaxCreditRating);
        occupationDetailsDto.MinCreditRating.Should().Be(occupation.MinCreditRating);
        occupationDetailsDto.SkillPointsPattern.Should().BeEquivalentTo(occupation.SkillPointsPattern);
        occupationDetailsDto.SuggestedContacts.Should().Be(occupation.SuggestedContacts);
    }

    [Test]
    public void Map_OccupationEntity_ShouldReturnOccupationDto() {
        // Arrange
        var generator = new OccupationEntityGenerator();
        var occupation = generator.Generate();
        // Act
        var occupationDto = _mapper.Map<OccupationDto>(occupation);
        // Assert
        occupationDto.Name.Should().Be(occupation.Name);
    }
}
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
	private static IMapper? _mapper;
	public OccupationMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_OccupationEntity_ShouldReturnOccupationDto() {
		// Arrange
		var generator = new OccupationEntityGenerator();
		var occupation = generator.Generate();
		// Act
		if (_mapper != null) {
			var occupationDto = _mapper.Map<OccupationDto>(occupation);
			// Assert
			occupationDto.Descritpion.Should().Be(occupation.Descritpion);
			occupationDto.Id.Should().Be(occupation.Id);
			occupationDto.Name.Should().Be(occupation.Name);
			occupationDto.Skills.Should().BeEquivalentTo(occupation.Skills);
			occupationDto.ImageUrl.Should().Be(occupation.ImageUrl);
			occupationDto.IsLovecraftian.Should().Be(occupation.IsLovecraftian);
			occupationDto.SkillPoints.Should().Be(occupation.SkillPoints);
			occupationDto.MaxCreditRating.Should().Be(occupation.MaxCreditRating);
			occupationDto.MinCreditRating.Should().Be(occupation.MinCreditRating);
		}
	}
}
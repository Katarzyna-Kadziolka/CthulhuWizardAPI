using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit; 

public class BackstoryMappingTests {
	private static IMapper _mapper;
	public BackstoryMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddProfile(new BackstoryMappingProfile());
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Backstory_ShouldReturnBackstoryDto() {
		// Arrange
		var backstory = BackstoryGenerator.Backstory;
		// Act
		var backstoryDto = _mapper.Map<BackstoryDto>(backstory);
		// Assert
		backstoryDto.Traits.Should().Be(backstory.Traits);
		backstoryDto.IdeologyBeliefs.Should().Be(backstory.IdeologyBeliefs);
		backstoryDto.InjuriesScars.Should().Be(backstory.InjuriesScars);
		backstoryDto.MeaningfulLocations.Should().Be(backstory.MeaningfulLocations);
		backstoryDto.PersonalDescription.Should().Be(backstory.PersonalDescription);
		backstoryDto.PhobiasManias.Should().Be(backstory.PhobiasManias);
		backstoryDto.SignificantPeople.Should().Be(backstory.SignificantPeople);
		backstoryDto.TreasuredPossessions.Should().Be(backstory.TreasuredPossessions);
		backstoryDto.ArcaneTomesSpellsAtifacts.Should().Be(backstory.ArcaneTomesSpellsAtifacts);
		backstoryDto.EncountersWithStrangeEntities.Should().Be(backstory.EncountersWithStrangeEntities);
	}
}
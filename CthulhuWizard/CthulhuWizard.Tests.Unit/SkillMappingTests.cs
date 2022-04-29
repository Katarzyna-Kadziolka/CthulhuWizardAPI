using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Application.Requests.Skills;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit; 

public class SkillMappingTests {
	private static IMapper _mapper;
	public SkillMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Skill_ShouldReturnSkillDto() {
		// Arrange
		var skill = SkillGenerator.Skill;
		// Act
		var skillDto = _mapper.Map<SkillDto>(skill);
		// Assert
		skillDto.Id.Should().Be(skill.Id);
		skillDto.Name.Should().Be(skill.Name);
		skillDto.CurrentValue.Should().Be(skill.CurrentValue);
		skillDto.IsRare.Should().Be(skill.IsRare);
		skillDto.MinValue.Should().Be(skill.MinValue);
	}
}
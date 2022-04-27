﻿using AutoMapper;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit; 

public class OccupationMappingTests {
	private static IMapper _mapper;
	public OccupationMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddProfile(new OccupationMappingProfile());
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Occupation_ShouldReturnOccupationDto() {
		// Arrange
		var occupation = OccupationGenerator.Occupation;
		// Act
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
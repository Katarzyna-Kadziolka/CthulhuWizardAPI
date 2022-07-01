﻿using System.Linq;
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Application.Requests.Skills;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class SkillMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_SkillEntity_ShouldReturnSkillDto() {
        // Arrange
        var generator = new SkillEntityGenerator();
        var skill = generator.Generate();
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
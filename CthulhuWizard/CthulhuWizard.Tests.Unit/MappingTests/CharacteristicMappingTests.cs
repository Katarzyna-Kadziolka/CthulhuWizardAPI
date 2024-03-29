﻿using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using CthulhuWizard.Tests.Shared.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests;

public class CharacteristicMappingTests {
    private static IMapper _mapper = TestMapper.Instance;

    [Test]
    public void Map_CharacteristicEntity_ShouldReturnCharacteristicDto() {
        // Arrange
        var generator = new CharacteristicEntityGenerator();
        var characteristic = generator.Generate();
        // Act
        var characteristicDto = _mapper.Map<CharacteristicDto>(characteristic);
        // Assert
        characteristicDto.Appearance.Should().Be(characteristic.Appearance);
        characteristicDto.Build.Should().Be(characteristic.Build);
        characteristicDto.Constitution.Should().Be(characteristic.Constitution);
        characteristicDto.Dexterity.Should().Be(characteristic.Dexterity);
        characteristicDto.Education.Should().Be(characteristic.Education);
        characteristicDto.Intelligence.Should().Be(characteristic.Intelligence);
        characteristicDto.Luck.Should().Be(characteristic.Luck);
        characteristicDto.Power.Should().Be(characteristic.Power);
        characteristicDto.Size.Should().Be(characteristic.Size);
        characteristicDto.Strength.Should().Be(characteristic.Strength);
        characteristicDto.DamageBonus.Should().Be(characteristic.DamageBonus);
        characteristicDto.HitPoints.Should().Be(characteristic.HitPoints);
        characteristicDto.MovementRate.Should().Be(characteristic.MovementRate);
        characteristic.MagicPoints.Should().Be(characteristic.MagicPoints);
        characteristic.Sanity.Should().Be(characteristic.Sanity);

    }
}
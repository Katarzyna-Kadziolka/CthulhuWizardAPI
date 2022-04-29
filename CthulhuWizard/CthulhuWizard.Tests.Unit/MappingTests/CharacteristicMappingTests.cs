using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests; 

public class CharacteristicMappingTests {
	private static IMapper? _mapper;
	public CharacteristicMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Characteristic_ShouldReturnCharacteristicDto() {
		// Arrange
		var characteristic = CharacteristicGenerator.CharacteristicEntity;
		// Act
		if (_mapper != null) {
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
		}
	}
}
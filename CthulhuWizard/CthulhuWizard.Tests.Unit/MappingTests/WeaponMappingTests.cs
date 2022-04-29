using System.Linq;
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Application.Requests.Weapons;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.MappingTests; 

public class WeaponMappingTests {
	private static IMapper? _mapper;
	public WeaponMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Weapon_ShouldReturnWeaponDto() {
		// Arrange
		var weapon = WeaponsGenerator.Weapons.First();
		// Act
		if (_mapper != null) {
			var weaponDto = _mapper.Map<WeaponDto>(weapon);
			// Assert
			weaponDto.Cost.Should().Be(weapon.Cost);
			weaponDto.Damage.Should().Be(weapon.Damage);
			weaponDto.Id.Should().Be(weapon.Id);
			weaponDto.Malfunction.Should().Be(weapon.Malfunction);
			weaponDto.Name.Should().Be(weapon.Name);
			weaponDto.Skill.Should().BeEquivalentTo(weapon.SkillEntity);
			weaponDto.BaseRange.Should().Be(weapon.BaseRange);
			weaponDto.IsImpale.Should().Be(weapon.IsImpale);
			weaponDto.BulletsInGun.Should().Be(weapon.BulletsInGun);
			weaponDto.UsesPerRound.Should().Be(weapon.UsesPerRound);
		}
	}
}
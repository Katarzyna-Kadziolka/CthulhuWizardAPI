using System.Linq;
using AutoMapper;
using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Application.Requests.Investigators.Mappings;
using CthulhuWizard.Tests.Shared;
using FluentAssertions;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit; 

public class EquipmentMappingTests {
	private static IMapper _mapper;
	public EquipmentMappingTests() {
		var mappingConfig = new MapperConfiguration(mc
			=> {
			mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
		});
		_mapper = mappingConfig.CreateMapper();
	}

	[Test]
	public void Map_Equipment_ShouldReturnEquipmentDto() {
		// Arrange
		var equipment = EquipmentGenerator.Equipments.First();
		// Act
		var equipmentDto = _mapper.Map<EquipmentDto>(equipment);
		// Assert
		equipmentDto.Id.Should().Be(equipment.Id);
		equipmentDto.Name.Should().Be(equipment.Name);
		equipmentDto.Price.Should().Be(equipment.Price);
	}
}
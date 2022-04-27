using AutoMapper;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Application.Requests.Equipments; 

public class EquipmentMappingProfile : Profile {
	public EquipmentMappingProfile() {
		CreateMap<Equipment, EquipmentDto>();
	}
}
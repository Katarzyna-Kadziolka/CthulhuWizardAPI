using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class EquipmentMappingProfile : Profile {
	public EquipmentMappingProfile() {
		CreateMap<Equipment, EquipmentDto>();
	}
}
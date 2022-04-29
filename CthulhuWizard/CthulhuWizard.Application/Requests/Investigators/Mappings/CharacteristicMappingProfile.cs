using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class CharacteristicMappingProfile : Profile {
	public CharacteristicMappingProfile() {
		CreateMap<CharacteristicEntity, CharacteristicDto>();
	}
}
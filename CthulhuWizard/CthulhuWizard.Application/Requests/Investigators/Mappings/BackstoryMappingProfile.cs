using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class BackstoryMappingProfile : Profile {
	public BackstoryMappingProfile() {
		CreateMap<BackstoryEntity, BackstoryDto>();
	}
}
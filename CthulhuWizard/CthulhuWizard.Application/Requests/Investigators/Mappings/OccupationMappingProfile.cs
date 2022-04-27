using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class OccupationMappingProfile : Profile {
	public OccupationMappingProfile() {
		CreateMap<Occupation, OccupationDto>();
	}
}
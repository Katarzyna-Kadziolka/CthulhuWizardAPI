using AutoMapper;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationMappingProfile : Profile {
	public OccupationMappingProfile() {
		CreateMap<OccupationEntity, OccupationDto>().ReverseMap();
	}
}
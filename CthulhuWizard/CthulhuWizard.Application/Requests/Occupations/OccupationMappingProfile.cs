using AutoMapper;
using CthulhuWizard.Application.Requests.Skills;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationMappingProfile : Profile {
	public OccupationMappingProfile() {
		CreateMap<Occupation, OccupationDto>();
	}
}
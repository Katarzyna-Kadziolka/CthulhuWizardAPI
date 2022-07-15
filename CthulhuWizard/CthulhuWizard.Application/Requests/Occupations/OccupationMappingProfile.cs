using AutoMapper;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationMappingProfile : Profile {
	public OccupationMappingProfile() {
		CreateMap<OccupationEntity, OccupationDetailsDto>().ReverseMap();
		CreateMap<OccupationEntity, OccupationDto>();
		CreateMap<OccupationSkillSpecificationEntity, OccupationSkillSpecificationDto>();
		CreateMap<SkillPointsPatternEntity, SkillPointsPatternDto>();
	}
}
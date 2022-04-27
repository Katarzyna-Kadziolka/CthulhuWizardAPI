using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class SkillMappingProfile : Profile {
	public SkillMappingProfile() {
		CreateMap<Skill, SkillDto>();
	}
}
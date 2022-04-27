using AutoMapper;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Application.Requests.Skills; 

public class SkillMappingProfile : Profile {
	public SkillMappingProfile() {
		CreateMap<Skill, SkillDto>();
	}
}
using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class InvestigatorMappingProfile : Profile {
	public InvestigatorMappingProfile() {
		CreateMap<InvestigatorEntity, InvestigatorDto>();
	}
}
using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class InvestigatorMappingProfile : Profile {
	public InvestigatorMappingProfile() {
		CreateMap<InvestigatorEntity, InvestigatorDto>();
		CreateMap<CreateInvestigatorCommand, InvestigatorEntity>();
	}
}
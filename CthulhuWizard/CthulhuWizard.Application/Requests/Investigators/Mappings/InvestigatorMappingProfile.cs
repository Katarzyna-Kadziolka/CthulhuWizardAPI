using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class InvestigatorMappingProfile : Profile {
	public InvestigatorMappingProfile() {
		CreateMap<InvestigatorEntity, InvestigatorDetailsDto>();
		CreateMap<CreateInvestigatorCommand, InvestigatorEntity>();
		CreateMap<InvestigatorEntity, InvestigatorDto>();
	}
}
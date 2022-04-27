using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class WeaponMappingProfile : Profile {
	public WeaponMappingProfile() {
		CreateMap<Weapon, WeaponDto>();
	}
}
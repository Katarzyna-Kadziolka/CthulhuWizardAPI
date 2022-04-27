using AutoMapper;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Application.Requests.Weapons; 

public class WeaponMappingProfile : Profile {
	public WeaponMappingProfile() {
		CreateMap<Weapon, WeaponDto>();
	}
}
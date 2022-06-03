using AutoMapper;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators.Mappings; 

public class AssetMappingProfile : Profile {
	public AssetMappingProfile() {
		CreateMap<AssetEntity, AssetDto>().ReverseMap();
	}
}
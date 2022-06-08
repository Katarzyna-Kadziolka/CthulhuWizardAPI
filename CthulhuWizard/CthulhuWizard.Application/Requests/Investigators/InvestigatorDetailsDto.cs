using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Application.Requests.Skills;
using CthulhuWizard.Application.Requests.Weapons;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR;

namespace CthulhuWizard.Application.Requests.Investigators; 

public class InvestigatorDetailsDto {
	public string? Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public int Age { get; set; }
	public Gender Gender{ get; set; }
	public string? BirthPlace { get; set; }
	public string? Residence { get; set; }
	public OccupationDetailsDto? Occupation { get; set; }
	public CharacteristicDto? Characteristic { get; set; }
	public List<SkillDto>? Skills { get; set; }
	public List<WeaponDto>? Weapons { get; set; }
	public List<EquipmentDto>? Equipments { get; set; }
	public AssetDto? Asset { get; set; }
	public BackstoryDto? Backstory { get; set; }
	public string? ImageUrl { get; set; }
}
﻿using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators; 

public class InvestigatorDto {
	public Guid Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public Gender Gender{ get; set; }
	public string BirthPlace { get; set; }
	public string Residence { get; set; }
	public OccupationDto Occupation { get; set; }
	public CharacteristicDto Characteristic { get; set; }
	public List<SkillDto> Skills { get; set; }
	public List<WeaponDto> Weapons { get; set; }
	public List<EquipmentDto> Equipments { get; set; }
	public AssetDto Asset { get; set; }
	public BackstoryDto Backstory { get; set; }
}
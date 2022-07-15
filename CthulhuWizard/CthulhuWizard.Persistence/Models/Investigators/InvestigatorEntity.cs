using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.Models.Investigators; 

public class InvestigatorEntity {
	public string Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public int Age { get; set; }
	public Gender Gender{ get; set; }
	public string? BirthPlace { get; set; }
	public string? Residence { get; set; }
	public OccupationEntity? Occupation { get; set; }
	public CharacteristicEntity? Characteristic { get; set; }
	public List<SkillEntity>? Skills { get; set; }
	public List<WeaponEntity>? Weapons { get; set; }
	public List<EquipmentEntity>? Equipments { get; set; }
	public AssetEntity? Asset { get; set; }
	public BackstoryEntity? Backstory { get; set; }
	public string? ImageUrl { get; set; }
}
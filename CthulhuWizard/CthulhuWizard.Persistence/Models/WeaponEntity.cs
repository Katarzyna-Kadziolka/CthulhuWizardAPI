namespace CthulhuWizard.Persistence.Models; 

public class WeaponEntity {
	public string Id { get; set; }
	public string? Name { get; set; }
	public SkillEntity? Skill { get; set; }
	public bool IsImpale { get; set; }
	public string? Damage { get; set; }
	public string? BaseRange { get; set; }
	public string? UsesPerRound { get; set; }
	public string? BulletsInGun { get; set; } 
	public double? Cost { get; set; }
	public int Malfunction { get; set; }
}
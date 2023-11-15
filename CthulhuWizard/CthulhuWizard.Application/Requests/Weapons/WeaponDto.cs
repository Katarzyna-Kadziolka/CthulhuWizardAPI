using CthulhuWizard.Application.Requests.Skills;

namespace CthulhuWizard.Application.Requests.Weapons; 

public class WeaponDto {
	public string Id { get; set; }
	public string? Name { get; set; }
	public string? Skill { get; set; }
	public bool IsImpale { get; set; }
	public string? Damage { get; set; }
	public string? BaseRange { get; set; }
	public string? UsesPerRound { get; set; }
	public string? BulletsInGun { get; set; } 
	public double? Cost { get; set; }
	public int Malfunction { get; set; }
}

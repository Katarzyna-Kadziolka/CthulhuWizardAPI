namespace CthulhuWizard.Application.Requests.Investigators; 

public class WeaponDto {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public SkillDto Skill { get; set; }
	public bool IsImpale { get; set; }
	public string Damage { get; set; }
	public string BaseRange { get; set; }
	public string UsesPerRound { get; set; }
	public string BulletsInGun { get; set; } 
	public int? Cost { get; set; }
	public int Malfunction { get; set; }
}
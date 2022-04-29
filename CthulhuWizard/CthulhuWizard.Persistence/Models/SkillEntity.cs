namespace CthulhuWizard.Persistence.Models; 

public class SkillEntity {
	public Guid Id { get; set; }
	public string? Name { get; set; }
	public int MinValue { get; set; }
	public int CurrentValue { get; set; }
	public bool IsRare { get; set; }
}
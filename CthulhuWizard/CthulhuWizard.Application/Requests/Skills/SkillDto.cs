namespace CthulhuWizard.Application.Requests.Skills; 

public class SkillDto {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public int MinValue { get; set; }
	public int CurrentValue { get; set; }
	public bool IsRare { get; set; }
}
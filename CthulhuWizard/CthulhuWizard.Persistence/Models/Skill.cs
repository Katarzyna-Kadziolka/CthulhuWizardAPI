namespace CthulhuWizard.Persistence.Models; 

public class Skill {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public int MinValue { get; set; }
	public bool IsRare { get; set; }
	public List<Occupation> Occupations { get; set; }
}
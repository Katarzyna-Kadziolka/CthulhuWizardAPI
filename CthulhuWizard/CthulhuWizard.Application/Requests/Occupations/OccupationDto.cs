using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Skills;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationDto {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string ImageUrl { get; set; }
	public string Descritpion { get; set; } 
	public bool IsLovecraftian { get; set; }
	public int? SkillPoints { get; set; }
	public int MinCreditRating { get; set; }
	public int MaxCreditRating { get; set; }
	public List<SkillDto> Skills { get; set; }
}
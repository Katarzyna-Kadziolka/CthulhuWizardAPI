namespace CthulhuWizard.Persistence.Models.Occupations; 

public class OccupationEntity {
	public string Id { get; set; }
	public string? Name { get; set; }
	public string? ImageUrl { get; set; }
	public string? Descritpion { get; set; }
	public string? SuggestedContacts { get; set; }
	public bool IsLovecraftian { get; set; }
	public int? SkillPoints { get; set; }
	public int MinCreditRating { get; set; }
	public int MaxCreditRating { get; set; }
	public List<OccupationSkillSpecificationEntity>? Skills { get; set; }
	public List<SkillPointsPatternEntity>? SkillPointsPattern { get; set; }
}

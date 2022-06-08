﻿using CthulhuWizard.Application.Requests.Skills;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationDetailsDto {
	public string? Id { get; set; }
	public string? Name { get; set; }
	public string? ImageUrl { get; set; }
	public string? Descritpion { get; set; } 
	public bool IsLovecraftian { get; set; }
	public int? SkillPoints { get; set; }
	public int MinCreditRating { get; set; }
	public int MaxCreditRating { get; set; }
	public string? Skills { get; set; }
	public string? SkillPointsPattern { get; set; }
}
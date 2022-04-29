﻿namespace CthulhuWizard.Persistence.Models; 

public class WeaponEntity {
	public Guid Id { get; set; }
	public string? Name { get; set; }
	public SkillEntity? SkillEntity { get; set; }
	public bool IsImpale { get; set; }
	public string? Damage { get; set; }
	public string? BaseRange { get; set; }
	public string? UsesPerRound { get; set; }
	public string? BulletsInGun { get; set; } 
	public int? Cost { get; set; }
	public int Malfunction { get; set; }
}
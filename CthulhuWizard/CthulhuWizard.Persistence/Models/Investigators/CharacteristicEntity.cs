namespace CthulhuWizard.Persistence.Models.Investigators; 

public class CharacteristicEntity {
	public int Strength { get; set; }
	public int Constitution { get; set; }
	public int Size { get; set; }
	public int Dexterity { get; set; }
	public int Appearance { get; set; }
	public int Intelligence { get; set; }
	public int Power { get; set; }
	public int Education { get; set; }
	public int Luck { get; set; }
	public DamageBonus DamageBonus { get; set; }
	public Build Build { get; set; }
	public int HitPoints { get; set; }
	public int MovementRate { get; set; }
	public int MagicPoints { get; set; }
	public int Sanity { get; set; }
}
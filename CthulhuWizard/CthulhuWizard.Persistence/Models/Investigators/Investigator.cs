namespace CthulhuWizard.Persistence.Models.Investigators; 

public class Investigator {
	public Guid Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public Gender Gender{ get; set; }
	public string BirthPlace { get; set; }
	public string Residence { get; set; }
	public Occupation Occupation { get; set; }
	public Characteristic Characteristic { get; set; }
	public List<Skill> Skills { get; set; }
	public List<Weapon> Weapons { get; set; }
	public List<Equipment> Equipments { get; set; }
	public Asset Assets { get; set; }
	public Backstory Backstory { get; set; }
}
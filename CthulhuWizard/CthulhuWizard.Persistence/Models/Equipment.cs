using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Persistence.Models; 

public class Equipment {
	public Guid Id { get; set; }
	public string Name { get; set; }
	public int Price { get; set; }
	public List<Investigator> Investigators { get; set; }
}
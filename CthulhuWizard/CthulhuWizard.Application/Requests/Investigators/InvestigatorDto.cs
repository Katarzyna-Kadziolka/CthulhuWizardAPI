using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Application.Requests.Investigators; 

public class InvestigatorDto {
    public string? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender{ get; set; }
    public string? ImageUrl { get; set; }
    public OccupationDto? Occupation { get; set; }
}
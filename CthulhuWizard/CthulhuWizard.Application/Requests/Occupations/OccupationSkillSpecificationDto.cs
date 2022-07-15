using CthulhuWizard.Application.Requests.Skills;

namespace CthulhuWizard.Application.Requests.Occupations; 

public class OccupationSkillSpecificationDto {
    public int HowMany { get; set; }
    public List<string>? From { get; set; }
}
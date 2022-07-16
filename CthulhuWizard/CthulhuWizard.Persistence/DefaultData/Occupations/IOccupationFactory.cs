using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData.Occupations; 

public interface IOccupationFactory {
    public OccupationEntity Create();
}
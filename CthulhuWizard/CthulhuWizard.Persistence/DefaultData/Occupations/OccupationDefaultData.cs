using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData.Occupations;

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data => OccupationsFactory.GetAll();
}

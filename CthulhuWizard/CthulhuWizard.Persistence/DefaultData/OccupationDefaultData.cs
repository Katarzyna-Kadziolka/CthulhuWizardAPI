using System.Reflection;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData;

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data => OccupationsFactory.GetAll();
}

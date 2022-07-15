using CthulhuWizard.Persistence.DefaultData.Occupations;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData;

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data = new() {
        Antiquarian.Seed(),
        Lumberjack.Seed(),
        Nurse.Seed(),
        Antiquarian.Seed(),
        Lumberjack.Seed(),
        Nurse.Seed(),
        Antiquarian.Seed(),
        Lumberjack.Seed(),
        Nurse.Seed(),
        Antiquarian.Seed(),
        Lumberjack.Seed(),
        Nurse.Seed(),
        SoldierMarine.Seed(),
        SoldierMarine.Seed()
    };
}
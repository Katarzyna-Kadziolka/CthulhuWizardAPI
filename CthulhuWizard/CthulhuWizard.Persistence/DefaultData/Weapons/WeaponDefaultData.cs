using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Weapons; 

public static class WeaponDefaultData {
    public static List<WeaponEntity> Data => WeaponFactory.GetAll();
}

using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Weapons; 

public class WeaponFactory {
    public static List<WeaponEntity> GetAll() {
        var types = typeof(IWeaponFactory).Assembly
            .GetTypes()
            .Where(p => typeof(IWeaponFactory).IsAssignableFrom(p) && !p.IsInterface);
        return types
            .Select(a => ((IWeaponFactory) Activator.CreateInstance(a)!).Create())
            .ToList();
    }
}

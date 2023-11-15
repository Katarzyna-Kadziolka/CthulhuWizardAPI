using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Weapons; 

public interface IWeaponFactory {
    public WeaponEntity Create();
}

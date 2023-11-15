using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Weapons; 

public class BowAndArrows : IWeaponFactory {
    public WeaponEntity Create() {
        return new WeaponEntity {
            Id = "9a88e762-1387-45ce-bdd2-33972a08bf6c",
            Name = "Bow and Arrows",
            Skill = SkillNames.Firearms.Bow,
            Damage = "1D6+half DB",
            BaseRange = "30 yards",
            UsesPerRound = "1",
            BulletsInGun = "1",
            Cost = 7,
            Malfunction = 97
        };
    }
}

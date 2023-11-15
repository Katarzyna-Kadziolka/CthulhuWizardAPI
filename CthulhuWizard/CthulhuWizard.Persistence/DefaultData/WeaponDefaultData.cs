using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class WeaponDefaultData {
    public static readonly List<WeaponEntity> Data = new() {
        new WeaponEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "Bow and Arrows",
            Skill = SkillDefaultData.Data.First(a => a.Name == "History"),
            Damage = "1D6+half DB",
            BaseRange = "30 yards",
            UsesPerRound = "1",
            BulletsInGun = "1",
            Cost = 7,
            Malfunction = 97
        }
    };
}
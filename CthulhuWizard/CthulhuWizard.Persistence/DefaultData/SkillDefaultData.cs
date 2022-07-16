using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class SkillDefaultData {
    public static List<SkillEntity> Data = new() {
        new SkillEntity {
            Name = "History",
            MinValue = 5,
        }
    };
}
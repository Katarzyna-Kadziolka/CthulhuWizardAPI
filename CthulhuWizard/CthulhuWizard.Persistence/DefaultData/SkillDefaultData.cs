using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class SkillDefaultData {
    public static List<SkillEntity> Data = new() {
        new SkillEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "History",
            CurrentValue = 0,
            MinValue = 5,
            IsRare = false
        }
    };
}
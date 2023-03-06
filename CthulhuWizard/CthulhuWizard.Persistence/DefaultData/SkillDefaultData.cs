using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class SkillDefaultData {
    public static List<SkillEntity> Data = new() {
        new SkillEntity {
            Name = "History",
            MinValue = 5,
        }
    };
    // TODO zrobić factorki dla każdego deafult data
}

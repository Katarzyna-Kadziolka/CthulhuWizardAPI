using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data = new List<OccupationEntity> {
        new OccupationEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion = "",
            ImageUrl = "",
            Skills = "1[Any]; 1[Any]; 1[Any];",
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[EDU]; 1[EDU];"
        }
    };
}
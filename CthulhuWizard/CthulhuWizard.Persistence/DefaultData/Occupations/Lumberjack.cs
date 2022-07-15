using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData.Occupations; 

public static class Lumberjack {
    public static OccupationEntity Seed() {
        return new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Lumberjack",
            Descritpion =
                "Laborers include factory workers, mill hands, stevedores, road crews, miners, construction, " +
                "and so on. Laborers fall into two camps: skilled and unskilled.",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Climb
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Dodge
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.History
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Fighting.Chainsaw
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.FirstAid
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Jump
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.MechanicalRepair
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.NaturalWorld,
                        SkillNames.Science.Biology,
                        SkillNames.Science.Botany
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Throw
                    }
                },
            },
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = new List<SkillPointsPatternEntity> {
                new() {
                    Multiplier = 2,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Education)
                    }
                },
                new() {
                    Multiplier = 2,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Dexterity),
                        nameof(CharacteristicEntity.Strength)
                    }
                }
            },
            SuggestedContacts = "Forestry workers, wilderness guides and conservationists"
        };
    }
}
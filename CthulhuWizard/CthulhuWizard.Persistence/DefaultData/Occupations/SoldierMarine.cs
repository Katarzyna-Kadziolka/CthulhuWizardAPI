using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData.Occupations; 

public static class SoldierMarine {
    public static OccupationEntity Seed() {
        return new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Soldier / Marine",
            Descritpion =
                "This refers to the enlisted ranks of the Army and Marines and includes the lowest ranks of " +
                "Private up through Gunnery Sergeant (in U.S. terms). Although technically outranked by even " +
                "the freshest of Second Lieutenants, Veteran Sergeants are respected by even the highest-ranking " +
                "officers. In the U.S., standard enlistment is for six years, including four years’ active duty " +
                "and two in standby (inactive) reserve.",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Climb,
                        SkillNames.Swim
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
                        SkillNames.Fighting.Any
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Firearms.Any
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Stealth
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Survival.Any
                    }
                },
                new() {
                    HowMany = 2,
                    From = new List<string> {
                        SkillNames.FirstAid,
                        SkillNames.MechanicalRepair,
                        SkillNames.OtherLanguage.Any
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
            SuggestedContacts = "Military, veterans associations."
        };
    }
}
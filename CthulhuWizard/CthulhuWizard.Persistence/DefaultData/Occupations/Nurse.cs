using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData.Occupations; 

public class Nurse : IOccupationFactory {
    public OccupationEntity Create() {
        return new() {
            Id = "abd76e9a-49b8-41f8-a66f-27cc5b2fc002",
            Name = "Nurse",
            Descritpion = "Nurses are trained healthcare assistants, usually working in hospitals, nursing homes, or " +
                          "with General Practitioners.",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.FirstAid
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Listen
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Medicine
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Psychology
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Science.Biology
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Science.Chemistry
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.SpotHidden
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Charm,
                        SkillNames.FastTalk,
                        SkillNames.Intimidate,
                        SkillNames.Persuade
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
            SuggestedContacts = "Hospital workers, physicians, community workers."
        };
    }
}
using CthulhuWizard.Persistence.DefaultData.Skills;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using CthulhuWizard.Persistence.Models.Occupations;

namespace CthulhuWizard.Persistence.DefaultData;

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data = new() {
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion =
                "A person who delights in the timeless excellence of design and execution, and in the power " +
                "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Appraise
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.ArtCraft.Any
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
                        SkillNames.LibraryUse
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.OtherLanguage.Any
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
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.SpotHidden
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Any
                    }
                },
            },
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = new List<SkillPointsPatternEntity> {
                new () {
                    Multiplier = 4,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Education)
                    }
                }
            },
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
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
        },


        new() {
            Id = Guid.NewGuid().ToString(),
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
        },

        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion =
                "A person who delights in the timeless excellence of design and execution, and in the power " +
                "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Appraise
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.ArtCraft.Any
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
                        SkillNames.LibraryUse
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.OtherLanguage.Any
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
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.SpotHidden
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Any
                    }
                },
            },
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = new List<SkillPointsPatternEntity> {
                new () {
                    Multiplier = 4,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Education)
                    }
                }
            },
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
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
        },


        new() {
            Id = Guid.NewGuid().ToString(),
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
        },

        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion =
                "A person who delights in the timeless excellence of design and execution, and in the power " +
                "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Appraise
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.ArtCraft.Any
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
                        SkillNames.LibraryUse
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.OtherLanguage.Any
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
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.SpotHidden
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Any
                    }
                },
            },
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = new List<SkillPointsPatternEntity> {
                new () {
                    Multiplier = 4,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Education)
                    }
                }
            },
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
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
        },


        new() {
            Id = Guid.NewGuid().ToString(),
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
        },

        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion =
                "A person who delights in the timeless excellence of design and execution, and in the power " +
                "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = new List<OccupationSkillSpecificationEntity> {
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Appraise
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.ArtCraft.Any
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
                        SkillNames.LibraryUse
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.OtherLanguage.Any
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
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.SpotHidden
                    }
                },
                new() {
                    HowMany = 1,
                    From = new List<string> {
                        SkillNames.Any
                    }
                },
            },
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = new List<SkillPointsPatternEntity> {
                new () {
                    Multiplier = 4,
                    PossibleAttributes = new List<string> {
                        nameof(CharacteristicEntity.Education)
                    }
                }
            },
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
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
        },


        new() {
            Id = Guid.NewGuid().ToString(),
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
        },

        new() {
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
        },

        new() {
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
        },
    };
}
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData; 

public static class OccupationDefaultData {
    public static List<OccupationEntity> Data = new() {
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion = "A person who delights in the timeless excellence of design and execution, and in the power " +
                          "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = "1[Appraise]; 1[ArtCraft.Any]; 1[History]; 1[LibraryUse]; 1[OtherLanguage]; 1[Charm, FastTalk, " +
                     "Intimidate, Persuade]; 1[SpotHidden]; 1[Any];",
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[EDU]; 1[EDU];",
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Lumberjack",
            Descritpion = "Laborers include factory workers, mill hands, stevedores, road crews, miners, construction, " +
                          "and so on. Laborers fall into two camps: skilled and unskilled.",
            ImageUrl = "",
            Skills = "1[Climb]; 1[Dodge]; 1[History]; 1[Fighting.Chainsaw]; 1[FirstAid]; 1[Jump]; 1[MechanicalRepair]; " +
                     "1[NaturalWorld, Science.Biology, Science.Botany]; 1[Throw];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Forestry workers, wilderness guides and conservationists"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Nurse",
            Descritpion = "Nurses are trained healthcare assistants, usually working in hospitals, nursing homes, or " +
                          "with General Practitioners.", 
            ImageUrl = "",
            Skills = "1[FirstAid]; 1[Listen]; 1[Medicine]; 1[Psychology]; 1[Science.Biology];  1[Science.Chemistry]; " +
                     "1[Spot Hidden]; 1[Charm, FastTalk, Intimidate, Persuade];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Hospital workers, physicians, community workers."
        },
                new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion = "A person who delights in the timeless excellence of design and execution, and in the power " +
                          "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = "1[Appraise]; 1[ArtCraft.Any]; 1[History]; 1[LibraryUse]; 1[OtherLanguage]; 1[Charm, FastTalk, " +
                     "Intimidate, Persuade]; 1[SpotHidden]; 1[Any];",
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[EDU]; 1[EDU];",
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Lumberjack",
            Descritpion = "Laborers include factory workers, mill hands, stevedores, road crews, miners, construction, " +
                          "and so on. Laborers fall into two camps: skilled and unskilled.",
            ImageUrl = "",
            Skills = "1[Climb]; 1[Dodge]; 1[History]; 1[Fighting.Chainsaw]; 1[FirstAid]; 1[Jump]; 1[MechanicalRepair]; " +
                     "1[NaturalWorld, Science.Biology, Science.Botany]; 1[Throw];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Forestry workers, wilderness guides and conservationists"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Nurse",
            Descritpion = "Nurses are trained healthcare assistants, usually working in hospitals, nursing homes, or " +
                          "with General Practitioners.", 
            ImageUrl = "",
            Skills = "1[FirstAid]; 1[Listen]; 1[Medicine]; 1[Psychology]; 1[Science.Biology];  1[Science.Chemistry]; " +
                     "1[Spot Hidden]; 1[Charm, FastTalk, Intimidate, Persuade];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Hospital workers, physicians, community workers."
        },
                new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion = "A person who delights in the timeless excellence of design and execution, and in the power " +
                          "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = "1[Appraise]; 1[ArtCraft.Any]; 1[History]; 1[LibraryUse]; 1[OtherLanguage]; 1[Charm, FastTalk, " +
                     "Intimidate, Persuade]; 1[SpotHidden]; 1[Any];",
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[EDU]; 1[EDU];",
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Lumberjack",
            Descritpion = "Laborers include factory workers, mill hands, stevedores, road crews, miners, construction, " +
                          "and so on. Laborers fall into two camps: skilled and unskilled.",
            ImageUrl = "",
            Skills = "1[Climb]; 1[Dodge]; 1[History]; 1[Fighting.Chainsaw]; 1[FirstAid]; 1[Jump]; 1[MechanicalRepair]; " +
                     "1[NaturalWorld, Science.Biology, Science.Botany]; 1[Throw];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Forestry workers, wilderness guides and conservationists"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Nurse",
            Descritpion = "Nurses are trained healthcare assistants, usually working in hospitals, nursing homes, or " +
                          "with General Practitioners.", 
            ImageUrl = "",
            Skills = "1[FirstAid]; 1[Listen]; 1[Medicine]; 1[Psychology]; 1[Science.Biology];  1[Science.Chemistry]; " +
                     "1[Spot Hidden]; 1[Charm, FastTalk, Intimidate, Persuade];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Hospital workers, physicians, community workers."
        },
                new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Antiquarian",
            Descritpion = "A person who delights in the timeless excellence of design and execution, and in the power " +
                          "of ancient lore. Probably the most Lovecraft-like occupation available to an investigator. ",
            ImageUrl = "",
            Skills = "1[Appraise]; 1[ArtCraft.Any]; 1[History]; 1[LibraryUse]; 1[OtherLanguage]; 1[Charm, FastTalk, " +
                     "Intimidate, Persuade]; 1[SpotHidden]; 1[Any];",
            IsLovecraftian = true,
            SkillPoints = 0,
            MinCreditRating = 30,
            MaxCreditRating = 70,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[EDU]; 1[EDU];",
            SuggestedContacts = "Booksellers, antique collectors, historical societies"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Lumberjack",
            Descritpion = "Laborers include factory workers, mill hands, stevedores, road crews, miners, construction, " +
                          "and so on. Laborers fall into two camps: skilled and unskilled.",
            ImageUrl = "",
            Skills = "1[Climb]; 1[Dodge]; 1[History]; 1[Fighting.Chainsaw]; 1[FirstAid]; 1[Jump]; 1[MechanicalRepair]; " +
                     "1[NaturalWorld, Science.Biology, Science.Botany]; 1[Throw];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Forestry workers, wilderness guides and conservationists"
        },
        new() {
            Id = Guid.NewGuid().ToString(),
            Name = "Nurse",
            Descritpion = "Nurses are trained healthcare assistants, usually working in hospitals, nursing homes, or " +
                          "with General Practitioners.", 
            ImageUrl = "",
            Skills = "1[FirstAid]; 1[Listen]; 1[Medicine]; 1[Psychology]; 1[Science.Biology];  1[Science.Chemistry]; " +
                     "1[Spot Hidden]; 1[Charm, FastTalk, Intimidate, Persuade];",
            IsLovecraftian = false,
            SkillPoints = 0,
            MinCreditRating = 9,
            MaxCreditRating = 30,
            SkillPointsPattern = "1[EDU]; 1[EDU]; 1[2[DEX, DEX], 2[STR, STR]];",
            SuggestedContacts = "Hospital workers, physicians, community workers."
        }
    };
}
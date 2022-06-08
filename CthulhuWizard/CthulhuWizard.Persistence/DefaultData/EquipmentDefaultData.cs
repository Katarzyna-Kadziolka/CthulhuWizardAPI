using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData;

public static class EquipmentDefaultData {
    public static List<EquipmentEntity> Data = new() {
        new EquipmentEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "Worsted Wool Dress Sui",
            Price = 17.95,
            Type = "Men’s Clothing"
        },
        new EquipmentEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "Chic Designer Dress",
            Price = 90,
            Type = "Women’s Clothing"
        },
        new EquipmentEntity {
            Id = Guid.NewGuid().ToString(),
            Name = "Aspirin (12 pills)",
            Price = 0.1,
            Type = "Medical Equipment"
        }
    };
}
using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments; 

public class Aspirin12Pills : IEquipmentFactory {
    public EquipmentEntity Create() {
        return new EquipmentEntity {
            Id = "29b806cb-463d-4930-ab16-42b5d4dca52b",
            Name = "Aspirin (12 pills)",
            Price = 0.1,
            Type = "Medical Equipment"
        };
    }
}

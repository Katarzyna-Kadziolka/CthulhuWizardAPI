using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments; 

public class ChicDesignerDress : IEquipmentFactory {
    public EquipmentEntity Create() {
        return new EquipmentEntity {
            Id = "337eea7a-afed-4167-93cf-66eb796a4133",
            Name = "Chic Designer Dress",
            Price = 90,
            Type = "Women’s Clothing"
        };
    }
}

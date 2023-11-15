using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments; 

public class WorstedWoolDressSui : IEquipmentFactory {
    public EquipmentEntity Create() {
        return new EquipmentEntity {
            Id = "f974984e-7e20-47df-8d16-ff368ee69ce9",
            Name = "Worsted Wool Dress Sui",
            Price = 17.95,
            Type = "Men’s Clothing"
        };
    }
}

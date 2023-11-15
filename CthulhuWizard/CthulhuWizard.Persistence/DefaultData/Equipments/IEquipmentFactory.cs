using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments; 

public interface IEquipmentFactory {
    public EquipmentEntity Create();
}

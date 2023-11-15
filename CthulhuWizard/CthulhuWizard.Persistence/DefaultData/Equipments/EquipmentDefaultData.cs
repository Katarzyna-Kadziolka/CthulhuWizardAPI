using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments;

public static class EquipmentDefaultData {
    public static List<EquipmentEntity> Data => EquipmentFactory.GetAll();
}

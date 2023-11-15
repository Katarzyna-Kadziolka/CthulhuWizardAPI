using CthulhuWizard.Persistence.Models;

namespace CthulhuWizard.Persistence.DefaultData.Equipments; 

public class EquipmentFactory {
    public static List<EquipmentEntity> GetAll() {
        var types = typeof(IEquipmentFactory).Assembly
            .GetTypes()
            .Where(p => typeof(IEquipmentFactory).IsAssignableFrom(p) && !p.IsInterface);
        return types
            .Select(a => ((IEquipmentFactory) Activator.CreateInstance(a)!).Create())
            .ToList();
    }
}

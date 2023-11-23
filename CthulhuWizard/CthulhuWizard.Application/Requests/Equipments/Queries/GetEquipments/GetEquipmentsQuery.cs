using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Equipments.Queries.GetEquipments; 

public class GetEquipmentsQuery : IQuery<List<EquipmentDto>> {
	public string? Name { get; set; }
	public double? Price { get; set; }
	public string? Type { get; set; }

}

using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Application.Requests.Equipments.Queries.GetEquipments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;
public class EquipmentsController : BaseApiController {
	private readonly IMediator _mediator;

	public EquipmentsController(IMediator mediator) {
		_mediator = mediator;
		
	}
	[HttpGet]
	public async Task<List<EquipmentDto>> Get([FromQuery] GetEquipmentsQuery query) {
		return await _mediator.Send(query);
	}
}

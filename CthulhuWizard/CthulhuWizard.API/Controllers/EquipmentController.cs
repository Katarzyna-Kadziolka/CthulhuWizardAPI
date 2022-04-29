using CthulhuWizard.Application.Requests.Equipments;
using CthulhuWizard.Application.Requests.Equipments.Queries.GetEquipments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;


[ApiController]
[Route("v1/[controller]")]
[ApiVersion("1.0")]
public class EquipmentController : ControllerBase {
	private readonly IMediator _mediator;

	public EquipmentController(IMediator mediator) {
		_mediator = mediator;
		
	}
	[HttpGet]
	public async Task<List<EquipmentDto>> Get([FromQuery] GetEquipmentsQuery query) {
		return await _mediator.Send(query);
	}
}
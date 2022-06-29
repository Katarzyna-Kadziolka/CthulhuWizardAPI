using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupationDetails;
using CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers; 

public class OccupationController : BaseApiController {
    private readonly IMediator _mediator;

    public OccupationController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<OccupationDto>> Get([FromQuery] GetOccupationsQuery query) {
        return await _mediator.Send(query);
    }

    [HttpGet("{id}")]
    public async Task<OccupationDetailsDto> Get([FromRoute] Guid id) {
        var query = new GetOccupationDetailsQuery {
            Id = id
        };
        return await _mediator.Send(query);
    }
}
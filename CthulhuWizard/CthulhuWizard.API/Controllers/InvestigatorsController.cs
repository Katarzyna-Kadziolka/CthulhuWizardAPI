using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Application.Requests.Investigators.Queries.GetinvestigatorDetails;
using CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;
public class InvestigatorsController : BaseApiController {
    private readonly IMediator _mediator;

    public InvestigatorsController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<InvestigatorDetailsDto> Post(CreateInvestigatorCommand command) {
        return await _mediator.Send(command);
    }

    [HttpGet]
    public async Task<List<InvestigatorDto>> Get([FromQuery] GetInvestigatorsQuery query) {
        return await _mediator.Send(query);
    }

    [HttpGet("{id}")]
    public async Task<InvestigatorDetailsDto> GetDetails([FromRoute] Guid id) {
        var query = new GetInvestigatorDetailsQuery {
            Id = id
        };
        return await _mediator.Send(query);
    }
}

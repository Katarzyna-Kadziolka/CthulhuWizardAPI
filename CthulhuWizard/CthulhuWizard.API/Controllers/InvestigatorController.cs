using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;
public class InvestigatorController : BaseApiController {
    private readonly IMediator _mediator;

    public InvestigatorController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<InvestigatorDto> Post(CreateInvestigatorCommand command) {
        return await _mediator.Send(command);
    }
}
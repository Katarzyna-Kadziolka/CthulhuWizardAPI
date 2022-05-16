using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers; 

[ApiController]
[Route("v1/[controller]")]
[ApiVersion("1.0")]
public class InvestigatorController {
    private readonly IMediator _mediator;

    public InvestigatorController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<InvestigatorDto> Post(CreateInvestigatorCommand command) {
        return await _mediator.Send(command);
    }
}
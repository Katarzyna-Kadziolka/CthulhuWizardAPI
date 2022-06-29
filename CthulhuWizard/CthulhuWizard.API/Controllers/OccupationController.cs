using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers; 

public class OccupationController : BaseApiController {
    private readonly IMediator _mediator;

    public OccupationController(IMediator mediator) {
        _mediator = mediator;
    }

}
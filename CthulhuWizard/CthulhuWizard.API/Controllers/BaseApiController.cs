using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[ApiVersion("1.0")]
public abstract class BaseApiController : ControllerBase { }
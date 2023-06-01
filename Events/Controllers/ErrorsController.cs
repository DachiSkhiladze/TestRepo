namespace Events.Controllers;

[Route(Routes.Errors.Controller)]
[ApiController]
public class ErrorsController : ControllerBase
{
    [HttpGet(HttpContextItemKeys.Error)]
    public IActionResult Error()
    {
        Exception? exception = HttpContext.Features.Get<ExceptionHandlerFeature>()?.Error;

        return Problem();
    }
}


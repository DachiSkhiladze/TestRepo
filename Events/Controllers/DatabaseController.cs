namespace Events.Controllers;

[Route(Routes.Database.Controller)]
public class DatabaseController : ApiController
{
    public DatabaseController(ISender mediator, IMapper mapper) : base(mediator, mapper) {}

    [HttpPost(Routes.Database.CreateDatabase)]
    public async Task<IActionResult> CreateDatabase(CreateDatabaseRequest request)
    {
        var command = _mapper.Map<CreateDatabaseCommand>(request);
        var send = await _mediator.Send(command);
        return send.Match(send => Ok(), errors => Problem(errors));
    }
}

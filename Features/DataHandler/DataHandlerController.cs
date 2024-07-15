using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PX_API.Features.DataHandler;

[ApiController]
[Route("[controller]/[action]")]
public class DataHandlerController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Save(DataHandlerHandler.Command command, [FromServices] IMediator mediator)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PX_API.Features.Solver;

[ApiController]
[Route("[controller]")]
public class SolverController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Index(SolverHandler.Command command, [FromServices] IMediator mediator)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
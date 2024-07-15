using MediatR;

namespace PX_API.Features.Solver;

public class SolverHandler : IRequestHandler<SolverHandler.Command, SolverHandler.Result>
{
    public class Command : IRequest<Result>
    {
        public string TestString { get; set; }
    }

    public class Result
    {
        public string TestString { get; set; }
        public string ResponseData { get; set; }
    }

    public async Task<Result> Handle(Command command, CancellationToken cancellationToken)
    {
        return new Result
        {
            TestString = "it works!",
            ResponseData = command.TestString
        };
    }
}
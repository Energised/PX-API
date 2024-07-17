using MediatR;
using PX_API.Models;

namespace PX_API.Features.Solver;

public class SolverHandler : IRequestHandler<SolverHandler.Command, SolverHandler.Result>
{
    public class Command : IRequest<Result>
    {
        public string TestString { get; set; }
        public Board BoardToSolve { get; set; }
    }

    public class Result
    {
        public Board SolvedBoard { get; set; }
    }

    public async Task<Result> Handle(Command command, CancellationToken cancellationToken)
    {
        var solverEngine = new Engine(command.BoardToSolve);
        solverEngine.Solve();
        
        return new Result
        {
            SolvedBoard = solverEngine.BoardData
        };
    }
}
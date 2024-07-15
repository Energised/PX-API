using PX_API.Models;

namespace PX_API.Features.DataHandler;

using MediatR;

public class DataHandlerHandler : IRequestHandler<DataHandlerHandler.Command, DataHandlerHandler.Result>
{
    public class Command : IRequest<Result>
    {
        public string TestString { get; set; }
        public Board BoardData { get; set; }
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
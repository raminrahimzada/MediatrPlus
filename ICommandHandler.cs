using MediatR;

namespace raminrahimzada
{    
    public  interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, ExecutionResult> where TCommand:AbstractCommand
    {
    }
}

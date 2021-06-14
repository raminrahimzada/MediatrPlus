using MediatR;

namespace raminrahimzada
{
    public abstract class AbstractQuery<TResponse> : IRequest<ExecutionResult<TResponse>>
    {
    }
}

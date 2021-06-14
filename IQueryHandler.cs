using MediatR;

namespace raminrahimzada
{
    public interface IQueryHandler<in TQuery, TResponse> :
        IRequestHandler<TQuery, ExecutionResult<TResponse>> where TQuery : AbstractQuery<TResponse>
    {
    }   
}

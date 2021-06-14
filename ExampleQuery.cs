using System.Threading;
using System.Threading.Tasks;

namespace raminrahimzada
{
    public class ExampleQuery : AbstractQuery<string>
    {
        //TODO
    }
    public partial class Handler:IQueryHandler<ExampleQuery,string>
    {
        public async Task<ExecutionResult<string>> Handle(ExampleQuery query, CancellationToken cancellationToken)
        {
            //TODO
            return ExecutionResult.Success("hello World");
        }
    }
}

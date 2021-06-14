using System.Threading;
using System.Threading.Tasks;

namespace raminrahimzada
{
    public class ExampleQuery : AbstractQuery<string>
    {
        //TODO your query parameters here
    }
    public partial class Handler:IQueryHandler<ExampleQuery,string>
    {
        public async Task<ExecutionResult<string>> Handle(ExampleQuery query, CancellationToken cancellationToken)
        {
            //TODO your query handling jobs here
            return ExecutionResult.Success("hello World");
        }
    }
}

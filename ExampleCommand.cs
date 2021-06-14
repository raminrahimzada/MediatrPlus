using System.Threading;
using System.Threading.Tasks;

namespace raminrahimzada
{
    public class ExampleCommand : AbstractCommand
    {
    }
    public partial class Handler : ICommandHandler<ExampleCommand>
    {
        public async Task<ExecutionResult> Handle(ExampleCommand request, CancellationToken cancellationToken)
        {
            //TODO
            return ExecutionResult.Success();
        }
    }
}

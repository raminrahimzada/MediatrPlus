using System.Threading;
using System.Threading.Tasks;

namespace raminrahimzada
{
    public class ExampleCommand : AbstractCommand
    {
       //TODO your command properties
    }
    public partial class Handler : ICommandHandler<ExampleCommand>
    {
        public async Task<ExecutionResult> Handle(ExampleCommand request, CancellationToken cancellationToken)
        {
            //TODO main job on handling command
            return ExecutionResult.Success();
        }
    }
}

using System.Threading.Tasks;
using Fibon.Messages;

namespace Fibon.Api.Handlers
{
    public class ValueCalculatedEvent2Handler : IEventHandler<ValueCalculatedEvent2>
    {
        private readonly IRepository _repo;

        public ValueCalculatedEvent2Handler(IRepository repo)
        {
            _repo = repo;
        }

        public async Task HandleAsync(ValueCalculatedEvent2 @event)
        {
            _repo.Insert(number: @event.Number, result: @event.Result);
            await Task.CompletedTask;
        }
    }
}

using PackagesManagementDomain.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PackagesManagement.Tools
{
    public class EventTrigger<T>
        where T : IEventNotification
    {
        private IEnumerable<IEventHandler<T>> handlers;
        public EventTrigger(IEnumerable<IEventHandler<T>> handlers)
        {
            this.handlers = handlers;
        }
        public async Task Trigger(T ev)
        {
            foreach (var handler in handlers)
                await handler.HandleAsync(ev);
        }
    }
}
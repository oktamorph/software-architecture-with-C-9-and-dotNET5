using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PackagesManagementBlazor.Server.DomainLayer
{
    public interface IEventMediator
    {
        Task TriggerEvents(IEnumerable<IEventNotification> events);
    }
}
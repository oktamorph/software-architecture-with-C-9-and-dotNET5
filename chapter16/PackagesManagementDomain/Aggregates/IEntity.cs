using PackagesManagementDomain.Events;
using System.Collections.Generic;

namespace PackagesManagementDomain.Aggregates
{
    public interface IEntity<T>
    {
        int Id { get; set; }
        List<IEventNotification> DomainEvents { get; }
    }

}
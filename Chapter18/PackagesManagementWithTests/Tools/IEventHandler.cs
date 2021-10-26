using PackagesManagementDomain.Events;
using System.Threading.Tasks;

namespace PackagesManagement.Tools
{
    public interface IEventHandler
    {
    }
    public interface IEventHandler<T> : IEventHandler
    where T : IEventNotification
    {
        Task HandleAsync(T ev);
    }
}
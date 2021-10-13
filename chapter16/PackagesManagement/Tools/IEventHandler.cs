using System.Threading.Tasks;
using PackagesManagementDomain.Events;

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
using System.Threading.Tasks;
using PackagesManagementBlazor.Server.DomainLayer;

namespace PackagesManagementBlazor.Server.Tools
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
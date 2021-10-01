using System.Threading.Tasks;

namespace PackagesManagement.Tools
{
    public interface IEventMediator
    {
        Task TriggerEvents(object domainEvents);
    }
}
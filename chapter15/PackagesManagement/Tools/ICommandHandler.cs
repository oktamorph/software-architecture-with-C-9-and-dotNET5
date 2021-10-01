using System.Threading.Tasks;

namespace PackagesManagement.Tools
{
    public interface ICommandHandler
    {
    }
    public interface ICommandHandler<T> : ICommandHandler
        where T : ICommand
    {
        Task HandleAsync(T command);
    }

}
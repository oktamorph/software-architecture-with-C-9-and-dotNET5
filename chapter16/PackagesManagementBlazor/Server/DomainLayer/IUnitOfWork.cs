using System.Threading.Tasks;

namespace PackagesManagementBlazor.Server.DomainLayer
{
    public interface IUnitOfWork
    {
        Task<bool> SaveEntitiesAsync();
        Task StartAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
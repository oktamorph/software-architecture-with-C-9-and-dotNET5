using System.Threading.Tasks;

namespace PackagesManagementDomain.IRepositories
{
    public interface IUnitOfWork
    {
        Task<bool> SaveEntitiesAsync();
        Task StartAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}

namespace PackagesManagementBlazor.Server.DomainLayer
{
    public interface IRepository
    {
    }
    public interface IRepository<T> : IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
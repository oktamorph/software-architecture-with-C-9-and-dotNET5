using PackagesManagementDomain.Aggregates;
using System.Threading.Tasks;

namespace PackagesManagementDomain.IRepositories
{
    public interface IPackageRepository : IRepository<IPackage>
    {
        Task<IPackage> Get(int id);
        IPackage New();
        Task<IPackage> Delete(int id);
    }

}

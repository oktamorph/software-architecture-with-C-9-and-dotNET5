using PackagesManagementDomain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PackagesManagementDomain.IRepository
{
    public interface IPackageRepository : IRepository<IPackage>
    {
        Task<IPackage> Get(int id);
        IPackage New();
        Task<IPackage> Delete(int id);
    }

}

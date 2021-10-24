using PackagesManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PackagesManagement.Queries
{
    public interface IPackageListQuery
    {
        Task<IEnumerable<PackageInfosViewModel>> GetAllPackages();
    }
}
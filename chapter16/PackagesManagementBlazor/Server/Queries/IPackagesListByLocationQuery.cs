using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.ApplicationLayer;
using PackagesManagementBlazor.Shared;

namespace PackagesManagementBlazor.Server.Queries
{
    public interface IPackagesListByLocationQuery : IQuery
    {
        Task<IEnumerable<PackageInfosViewModel>> GetPackagesOf(string location);
    }

}

using PackagesManagementDB.Models;
using PackagesManagementDomain.Aggregates;
using PackagesManagementDomain.Events;
using PackagesManagementDomain.IRepositories;
using System.Threading.Tasks;

namespace PackagesManagementDB.Repositories
{
    public interface IPackageRepository
    {
        MainDbContext context { get; }

        public async Task<IPackage> Delete(int id)
        {
            var model = await Get(id);
            if (model is not Package package) return null;
            context.Packages.Remove(package);
            model.AddDomainEvent(new PackageDeleteEvent(model.Id, package.EntityVersion));
            return model;
        }

        Task<Package> Get(int id);
        IUnitOfWork UnitOfWork { get; }
    }

}

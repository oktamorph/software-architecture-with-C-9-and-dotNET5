using PackagesManagementDomain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagesManagement.Handlers
{
    public class PackagePriceChangedEventHandler : IEventhandler<PackagePriceChangedEvent>
    {
        private readonly IPackageEventRepository repo;
        public PackagePriceChangedEventHandler(IPackageEventRepository repo)
        {
            this.repo = repo;
        }
        public Task HandleAsync(PackagePriceChangedEvent ev)
        {
            repo.New(PackageEventType.CostChanged, ev.PackageId, ev.OldVersion, ev.NewVersion, ev.NewPrice);
            return Task.CompletedTask;
        }
    }
}

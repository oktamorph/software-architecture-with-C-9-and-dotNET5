using System;
using System.Collections.Generic;
using System.Text;
using PackagesManagementDomain.DTOs;

namespace PackagesManagementDomain.Aggregates
{
    public interface IPackage : IEntity<int>
    {
        void FullUpdate(IPackageFullEditDTO o);
        string Name { get; set; }

        string Description { get; set; }
        decimal Price { get; set; }
        int DurationInDays { get; }
        DateTime? StartValidityDate { get;  }
        DateTime? EndValidityDate { get; }
        int DestinationId { get; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace PackagesManagementDomain.DTOs
{
    public interface IPackageFullEditDTO
    {
        int Id { get; }
        int DestinationId { get; }
        decimal Price { get; }
        string Name { get; }
        string Description { get; }
        int DurationInDays { get; }
        DateTime? StartValidityDate { get; }
        DateTime? EndValidityDate { get; }
    }

}

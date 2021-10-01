using PackagesManagementDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PackagesManagement.Models
{
    public class PackageInfosViewModel
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
        [MaxLength(128), Required]
        public string Name { get; set; }
        [MaxLength(128)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationInDays { get; set; }
        public DateTime? StartValidityDate { get; set; }
        public DateTime? EndValidityDate { get; set; }
        public Destination MyDestination { get; set; }
        [ConcurrencyCheck]
        public long EntityVersion { get; set; }
        public int DestinationId { get; set; }
    }
}

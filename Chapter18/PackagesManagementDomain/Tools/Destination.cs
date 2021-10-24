using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PackagesManagementDomain.Tools
{
    public class Destination
    {
        public int Id { get; set; }
        [MaxLength(128), Required]
        public string Name { get; set; }
        [MaxLength(128), Required]
        public string Country { get; set; }
        public string Description { get; set; }
        public ICollection<Package> Packages { get; set; }
    }

}

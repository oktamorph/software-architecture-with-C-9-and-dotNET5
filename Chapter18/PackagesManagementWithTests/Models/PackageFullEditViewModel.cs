using PackagesManagementDomain.Aggregates;
using PackagesManagementDomain.DTOs;
using System;
using System.ComponentModel.DataAnnotations;

namespace PackagesManagement.Models
{
    public class PackageFullEditViewModel : IPackageFullEditDTO
    {
        public PackageFullEditViewModel() { }
        public PackageFullEditViewModel(IPackage o)
        {
            Id = o.Id;
            DestinationId = o.DestinationId;
            Name = o.Name;
            Description = o.Description;
            Price = o.Price;
            DurationInDays = o.DurationInDays;
            StartValidityDate = o.StartValidityDate;
            EndValidityDate = o.EndValidityDate;
        }
        public int Id { get; set; }
        [Display(Name = "name")]
        [StringLength(128, MinimumLength = 5), Required]
        public string Name { get; set; }
        [Display(Name = "package infos")]
        [StringLength(128, MinimumLength = 10), Required]
        public string Description { get; set; }
        [Display(Name = "price")]
        [Range(0, 100000)]
        public decimal Price { get; set; }
        [Display(Name = "duration in days")]
        [Range(1, 90)]
        public int DurationInDays { get; set; }
        [Display(Name = "available from")]
        public DateTime? StartValidityDate { get; set; }
        [Display(Name = "available to")]
        public DateTime? EndValidityDate { get; set; }
        [Display(Name = "destination")]
        public int DestinationId { get; set; }
    }

}

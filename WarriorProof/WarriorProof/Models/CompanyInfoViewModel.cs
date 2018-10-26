using System;
using System.ComponentModel.DataAnnotations;

namespace WarriorProof.Models
{
    public class CompanyInfoViewModel
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}

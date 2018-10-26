using System;
namespace WarriorProof.Contracts.Models
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual Address Address { get; set; }
        public virtual Trucks Trucks { get; set; }

    }
}

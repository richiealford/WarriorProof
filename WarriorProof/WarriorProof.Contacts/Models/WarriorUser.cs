using System;
namespace WarriorProof.Contacts.Models
{
    public class WarriorUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}

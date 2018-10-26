using System;
using System.ComponentModel.DataAnnotations;

namespace WarriorProof.Models
{
    public class RegistrationViewModel
    {
        public PersonalInfoViewModel PersonalInfo { get; set; }
        public CompanyInfoViewModel CompanyInfo { get; set; }
        public TrucksInfoViewModel TrucksInfo { get; set; }
        public LoginInfoViewModel LoginInfo { get; set; }

    }
}
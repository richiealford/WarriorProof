using System;
using System.ComponentModel.DataAnnotations;

namespace WarriorProof.Models
{
    public class LoginInfoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$",
                           ErrorMessage = "Password must be at least 6 characters long and include at least one capital letter and one digit.")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string PasswordConfirm { get; set; }
    }
}

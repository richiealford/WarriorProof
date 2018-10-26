﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WarriorProof.Models
{
    public class PersonalInfoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        
    }
}

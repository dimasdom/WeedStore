using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Models.DTOs
{
    public class UserRegisterDTOs
    {
        [DataType("Email")]
        [Required]
        public string Email { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Second_name { get; set; }
        [Required]
        [DataType("Password")]
        [MinLength(8)]
        [MaxLength(24)]
        public string Password { get; set; }
        [Required]
        public string VerifiedPassword { get; set; }

    }
}

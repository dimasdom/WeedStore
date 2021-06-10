using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Models.DTOs
{
    public class UserLoginDTOs
    {
        [Required]
        [DataType("Email")]
        public string Email { get; set; }
        [Required]
        [DataType("Password")]
        [MinLength(8)]
        [MaxLength(24)]
        public string Password { get; set; }
    }
}

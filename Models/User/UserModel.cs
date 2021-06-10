using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Models.User
{
    public class UserModel : IdentityUser
    {
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Cart{ get; set; }
        public string Address { get; set; }

    }
}

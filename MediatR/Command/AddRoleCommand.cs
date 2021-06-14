using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class AddRoleCommand : IRequest<List<IdentityRole>>
    {
        public AddRoleCommand(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; set; }
    }
}

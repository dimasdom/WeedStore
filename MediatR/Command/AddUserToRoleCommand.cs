using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class AddUserToRoleCommand:IRequest<List<UserModel>>
    {
        public AddUserToRoleCommand(string userName, string roleName)
        {
            UserName = userName;
            RoleName = roleName;
        }

        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}

using MediatR;
using System.Collections.Generic;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class AddUserToRoleCommand : IRequest<List<UserModel>>
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

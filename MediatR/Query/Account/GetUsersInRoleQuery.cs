using MediatR;
using System.Collections.Generic;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Query
{
    public class GetUsersInRoleQuery : IRequest<List<UserModel>>
    {
        public GetUsersInRoleQuery(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; set; }
    }
}

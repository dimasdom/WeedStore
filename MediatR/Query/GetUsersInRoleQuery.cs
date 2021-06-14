using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class GetUsersInRoleHandler : IRequestHandler<GetUsersInRoleQuery, List<UserModel>>
    {
        private readonly UserManager<UserModel> _userManager;

        public GetUsersInRoleHandler(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<UserModel>> Handle(GetUsersInRoleQuery request, CancellationToken cancellationToken)
        {
            var users = await _userManager.GetUsersInRoleAsync(request.RoleName);
            return new List<UserModel>(users);
        }
    }
}

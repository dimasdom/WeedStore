﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class AddUserToRoleHandler : IRequestHandler<AddUserToRoleCommand, List<UserModel>>
    {
        private readonly UserManager<UserModel> _userManager;

        public AddUserToRoleHandler(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<UserModel>> Handle(AddUserToRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            var result  = await _userManager.AddToRoleAsync(user, request.RoleName);
            
            if (result.Succeeded)
            {
                var users = await _userManager.GetUsersInRoleAsync(request.RoleName);
                return new List<UserModel>(users);
            }
            return null;
        }
    }
}

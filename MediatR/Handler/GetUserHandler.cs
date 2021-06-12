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
    //public class GetUserHandler : IRequestHandler<GetUsersQuery, UserModel>
    //{
    //    private UserManager<UserModel> _userManager;

    //    public GetUserHandler(UserManager<UserModel> userManager)
    //    {
    //        _userManager = userManager;
    //    }

    //    public async Task<UserModel> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    //    {
    //        var Customer =  await _userManager.FindByIdAsync();
    //    }
    //}
}

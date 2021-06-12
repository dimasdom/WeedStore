using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class EditUserHandler : IRequestHandler<EditUserCommand, UserModel>
    {
        public readonly WeedStoreContext _context;
        public readonly UserManager<UserModel> _userManager;

        public EditUserHandler(WeedStoreContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<UserModel> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var OldUser = await _userManager.FindByIdAsync(request.NewUser.Id);
            _context.Users.Remove(OldUser);
            _context.Users.Add(request.NewUser);
        }
    }
}

﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class LogOutHandler : IRequestHandler<LogOutCommand, bool>
    {
        private readonly SignInManager<UserModel> _signInManager;

        public LogOutHandler(SignInManager<UserModel> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<bool> Handle(LogOutCommand request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();
            return true;
        }
    }
}

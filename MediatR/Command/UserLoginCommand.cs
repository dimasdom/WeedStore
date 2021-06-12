using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.DTOs;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class UserLoginCommand:IRequest<UserModel>
    {
        public UserLoginCommand(UserLoginDTOs user)
        {
            User = user;
        }

        public UserLoginDTOs User { get; set; }
    }
}

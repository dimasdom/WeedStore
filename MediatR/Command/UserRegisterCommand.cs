using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.DTOs;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class UserRegisterCommand:IRequest<UserModel>
    {
        public UserRegisterCommand(UserRegisterDTOs user)
        {
            User = user;
        }

        public UserRegisterDTOs User { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class EditUserCommand:IRequest<UserModel>
    {
        public EditUserCommand(UserModel newUser)
        {
            NewUser = newUser;
        }

        public UserModel NewUser { get; set; }
    }
}

using MediatR;
using WeedStore.Models.DTOs;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class UserRegisterCommand : IRequest<UserModel>
    {
        public UserRegisterCommand(UserRegisterDTOs user)
        {
            User = user;
        }

        public UserRegisterDTOs User { get; set; }
    }
}

using MediatR;
using WeedStore.Models.DTOs;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Command
{
    public class UserLoginCommand : IRequest<UserModel>
    {
        public UserLoginCommand(UserLoginDTOs user)
        {
            User = user;
        }

        public UserLoginDTOs User { get; set; }
    }
}

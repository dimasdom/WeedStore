using MediatR;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Query
{
    public class GetUserQuery : IRequest<UserModel>
    {
        public GetUserQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}

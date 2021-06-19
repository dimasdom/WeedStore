using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, UserModel>
    {
        private UserManager<UserModel> _userManager;

        public GetUserHandler(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var Customer = await _userManager.FindByNameAsync(request.UserName);
            return Customer;
        }
    }
}

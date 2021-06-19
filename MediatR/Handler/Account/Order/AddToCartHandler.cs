using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class AddToCartHandler : IRequestHandler<AddToCartCommand, bool>
    {
        private readonly WeedStoreContext _context;
        private readonly UserManager<UserModel> _userManager;

        public AddToCartHandler(WeedStoreContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<bool> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            var userFromContext = await _context.Users.FindAsync(user.Id);
            List<string> newUserCart = JsonSerializer.Deserialize<List<string>>(userFromContext.Cart);
            newUserCart.Add(request.GoodsId);
            userFromContext.Cart = JsonSerializer.Serialize(newUserCart);
            var result = await _context.SaveChangesAsync();
            return true;
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Order;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class MakeOrderHandler : IRequestHandler<MakeOrderCommand, bool>
    {
        private readonly WeedStoreContext _context;
        private readonly UserManager<UserModel> _userManager;

        public MakeOrderHandler(WeedStoreContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<bool> Handle(MakeOrderCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            var UserFromContext = await _context.Users.FindAsync(user.Id);

            OrderModel NewOrder = new OrderModel { Address = request.Address, UserId = Guid.Parse(user.Id), GoodsIds = UserFromContext.Cart };
            _context.Orders.Add(NewOrder);
            UserFromContext.Cart = "[]";
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

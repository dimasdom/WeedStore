using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;
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
            int OrderSum = 0;
            var userCart = JsonSerializer.Deserialize<List<Guid>>(UserFromContext.Cart);
            List<GoodsModel> CartList = new List<GoodsModel>();
            foreach (Guid guid in userCart)
            {
                var goods = _context.Goods.Find(guid);
                CartList.Add(goods);
                goods.Count -= 1;
                _context.SaveChanges();

            }
            foreach (GoodsModel goods in CartList)
            {
                OrderSum = OrderSum + goods.Price;
            }
            OrderModel NewOrder = new OrderModel { Address = request.Address, UserId = Guid.Parse(user.Id), GoodsIds = UserFromContext.Cart, Status = "Wait for confirmation", Sum = OrderSum, Date = DateTime.Now };
            _context.Orders.Add(NewOrder);

            UserFromContext.Cart = "[]";
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

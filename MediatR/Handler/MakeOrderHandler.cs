using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Handler
{
    public class MakeOrderHandler : IRequestHandler<MakeOrderCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public MakeOrderHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(MakeOrderCommand request, CancellationToken cancellationToken)
        {
            var newOrder = new OrderModel
            {
                GoodsIds = request.Order.GoodsIds,
                Address = request.Order.Address,
                UserId = request.Order.UserId
            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return true;
        }
    }
}

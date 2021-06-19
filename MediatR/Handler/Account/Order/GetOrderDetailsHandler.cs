using MediatR;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.Context;
using WeedStore.Models.DTOs;
using WeedStore.Models.Goods;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Handler
{
    public class GetOrderDetailsHandler : IRequestHandler<GetOrderDetailsQuery, OrderDetailsModel>
    {
        private readonly WeedStoreContext _context;


        public GetOrderDetailsHandler(WeedStoreContext context)
        {
            _context = context;

        }

        public async Task<OrderDetailsModel> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            OrderModel order = await _context.Orders.FindAsync(request.Id);
            var GoodsIds = JsonSerializer.Deserialize<List<Guid>>(order.GoodsIds);
            List<GoodsModel> goods = new List<GoodsModel>();
            foreach (Guid guid in GoodsIds)
            {
                goods.Add(_context.Goods.Find(guid));
            }
            OrderDetailsModel orderDetails = new OrderDetailsModel(goods, order);
            return orderDetails;
        }
    }
}

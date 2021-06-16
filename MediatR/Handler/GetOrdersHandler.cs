using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.Context;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Handler
{
    public class GetOrdersHandler : IRequestHandler<GetOrdersQuery, List<OrderModel>>
    {
        private readonly WeedStoreContext _context;

        public GetOrdersHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<List<OrderModel>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {

            var Orders =  _context.Orders.ToList();
            return Orders;

        }
    }
}

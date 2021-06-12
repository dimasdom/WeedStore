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
    public class GetUsersOrdersHandler : IRequestHandler<GetUsersOrdersQuery, List<OrderModel>>
    {
        private readonly WeedStoreContext _context;
        public async Task<List<OrderModel>> Handle(GetUsersOrdersQuery request, CancellationToken cancellationToken)
        {
            // var Orders =  _context.Orders.Where(x => x.UserId ==).ToList();
            // return Orders;
            return new List<OrderModel> { };
        }
    }
}

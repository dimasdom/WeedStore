using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Query
{
    public class GetOrdersQuery:IRequest<List<OrderModel>>
    {
    }
}

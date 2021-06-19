using MediatR;
using System.Collections.Generic;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Query
{
    public class GetOrdersQuery : IRequest<List<OrderModel>>
    {

    }
}

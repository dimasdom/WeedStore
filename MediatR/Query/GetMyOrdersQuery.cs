using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Query
{
    public class GetMyOrdersQuery:IRequest<List<OrderModel>>
    {
        public GetMyOrdersQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}

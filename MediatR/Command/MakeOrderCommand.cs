using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Command
{
    public class MakeOrderCommand:IRequest<bool>
    {
        public MakeOrderCommand(OrderModel order)
        {
            Order = order;
        }

        public OrderModel Order { get; set; }
    }
}

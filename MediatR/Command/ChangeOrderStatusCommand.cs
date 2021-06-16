using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class ChangeOrderStatusCommand:IRequest<bool>
    {
        public ChangeOrderStatusCommand(Guid orderId, string newStatus)
        {
            OrderId = orderId;
            NewStatus = newStatus;
        }

        public Guid OrderId { get; set; }
        public string NewStatus { get; set; }
    }
}

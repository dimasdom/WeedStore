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
        public MakeOrderCommand(string userName, string address)
        {
            UserName = userName;
            Address = address;
        }

        public string UserName { get; set; }
        public string Address { get; set; }
    }
}

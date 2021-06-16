using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.DTOs;
using WeedStore.Models.Order;

namespace WeedStore.MediatR.Query
{
    public class GetOrderDetailsQuery:IRequest<OrderDetailsModel>
    {
        public GetOrderDetailsQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

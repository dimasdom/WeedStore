using MediatR;
using System;
using WeedStore.Models.DTOs;

namespace WeedStore.MediatR.Query
{
    public class GetOrderDetailsQuery : IRequest<OrderDetailsModel>
    {
        public GetOrderDetailsQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

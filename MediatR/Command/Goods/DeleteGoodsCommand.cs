using MediatR;
using System;

namespace WeedStore.MediatR.Command
{
    public class DeleteGoodsCommand : IRequest<bool>
    {
        public DeleteGoodsCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

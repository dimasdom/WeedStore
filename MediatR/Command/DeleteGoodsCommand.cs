using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class DeleteGoodsCommand:IRequest<bool>
    {
        public DeleteGoodsCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

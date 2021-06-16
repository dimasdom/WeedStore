using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;

namespace WeedStore.MediatR.Handler
{
    public class DeleteGoodsHandler : IRequestHandler<DeleteGoodsCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public DeleteGoodsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteGoodsCommand request, CancellationToken cancellationToken)
        {
            var GoodsToRemove = await _context.Goods.FindAsync(request.Id);
            _context.Goods.Remove(GoodsToRemove);
             _context.SaveChanges();
            return true;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class EditGoodsHandler : IRequestHandler<EditGoodsCommand, GoodsModel>
    {
        private readonly WeedStoreContext _context;

        public EditGoodsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<GoodsModel> Handle(EditGoodsCommand request, CancellationToken cancellationToken)
        {
            var oldGoods = await _context.Goods.FindAsync(request.NewGoods.Id);
            request.NewGoods.Id = oldGoods.Id;
            _context.Goods.Remove(oldGoods);
            _context.Goods.Add(request.NewGoods);
            await _context.SaveChangesAsync();
            return request.NewGoods;
        }
    }
}

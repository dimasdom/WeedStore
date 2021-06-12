using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class GetSingleGoodsHandler : IRequestHandler<GetSingleGoodsQuery, GoodsModel>
    {
        private readonly WeedStoreContext _context;

        public GetSingleGoodsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<GoodsModel> Handle(GetSingleGoodsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Goods.FindAsync(request.Id);
        }
    }
}

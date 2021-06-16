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
    public class GetGoodsWithParamsHandler : IRequestHandler<GetGoodsWithParamsQuery, List<GoodsModel>>
    {
        private readonly WeedStoreContext _context;

        public GetGoodsWithParamsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<List<GoodsModel>> Handle(GetGoodsWithParamsQuery request, CancellationToken cancellationToken)
        {
            if (request.CategoryId != null)
            {
                if (request.MaxPrice != null || request.MinPrice != null)
                {
                    if (request.MaxPrice != null && request.MinPrice != null)
                    {
                        return _context.Goods.Where(x => x.CategoryId == Guid.Parse(request.CategoryId) && x.Price < Int32.Parse(request.MaxPrice) && x.Price > Int32.Parse(request.MinPrice)).ToList();
                    }
                    if (request.MaxPrice != null)
                    {
                        return _context.Goods.Where(x => x.CategoryId == Guid.Parse(request.CategoryId) && x.Price < Int32.Parse(request.MaxPrice)).ToList();
                    }
                    if (request.MinPrice != null)
                    {
                        return _context.Goods.Where(x => x.CategoryId == Guid.Parse(request.CategoryId) && x.Price < Int32.Parse(request.MinPrice)).ToList();
                    }
                    
                }
                return _context.Goods.Where(x => x.CategoryId == Guid.Parse(request.CategoryId)).ToList();
            }
            if (request.MaxPrice != null || request.MinPrice != null)
            {
                if (request.MaxPrice != null && request.MinPrice != null)
                {
                    return _context.Goods.Where(x => x.CategoryId == Guid.Parse(request.CategoryId) && x.Price < Int32.Parse(request.MaxPrice) && x.Price > Int32.Parse(request.MinPrice)).ToList();
                }
                if (request.MaxPrice != null)
                {
                    return _context.Goods.Where(x => x.Price < Int32.Parse(request.MaxPrice)).ToList();
                }
                if (request.MinPrice != null)
                {
                    return _context.Goods.Where(x => x.Price > Int32.Parse(request.MinPrice)).ToList();
                }
               
            }
            return null;
        }
    }
}

﻿using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetGoodsHandler : IRequestHandler<GetGoodsQuery, List<GoodsModel>>
    {
        private readonly WeedStoreContext _context;

        public GetGoodsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public  async Task<List<GoodsModel>> Handle(GetGoodsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Goods.ToListAsync();
        }
    }
}

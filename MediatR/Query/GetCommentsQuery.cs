﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Query
{
    public class GetCommentsQuery : IRequest<List<CommentModel>>
    {
        public GetCommentsQuery(Guid goodsId)
        {
            GoodsId = goodsId;
        }

        public Guid GoodsId { get; set; }
    }
}

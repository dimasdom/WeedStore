using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Query
{
    public class GetSingleGoodsQuery:IRequest<GoodsModel>
    {
        public GetSingleGoodsQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

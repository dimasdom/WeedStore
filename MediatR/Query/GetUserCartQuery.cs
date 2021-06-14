using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Query
{
    public class GetUserCartQuery : IRequest<List<GoodsModel>>
    {
        public GetUserCartQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}

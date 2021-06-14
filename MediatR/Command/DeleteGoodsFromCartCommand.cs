using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class DeleteGoodsFromCartCommand:IRequest<bool>
    {
        public DeleteGoodsFromCartCommand(string userName, string goodsId)
        {
            UserName = userName;
            GoodsId = goodsId;
        }

        public string UserName { get; set; }
        public string GoodsId { get; set; }
    }
}

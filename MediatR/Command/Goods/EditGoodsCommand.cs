using MediatR;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Command
{
    public class EditGoodsCommand : IRequest<GoodsModel>
    {
        public GoodsModel NewGoods { get; set; }
        public EditGoodsCommand(GoodsModel newGoods)
        {
            NewGoods = newGoods;
        }


    }
}

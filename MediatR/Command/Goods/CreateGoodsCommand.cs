using MediatR;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Command
{
    public class CreateGoodsCommand : IRequest<bool>
    {
        public CreateGoodsCommand(GoodsModel goods)
        {
            Goods = goods;
        }

        public GoodsModel Goods { get; set; }
    }
}

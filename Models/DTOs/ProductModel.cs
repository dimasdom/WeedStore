using System.Collections.Generic;
using WeedStore.Models.Goods;

namespace WeedStore.Models.DTOs
{
    public class ProductModel
    {
        public GoodsModel Goods { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}

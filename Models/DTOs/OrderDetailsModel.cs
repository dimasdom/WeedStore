using System.Collections.Generic;
using WeedStore.Models.Goods;
using WeedStore.Models.Order;

namespace WeedStore.Models.DTOs
{
    public class OrderDetailsModel
    {
        public OrderDetailsModel(List<GoodsModel> goods, OrderModel orderDetails)
        {
            Goods = goods;
            OrderDetails = orderDetails;
        }

        public List<GoodsModel> Goods { get; set; }
        public OrderModel OrderDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Models.Order
{
    public class OrderModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string GoodsIds { get; set; }
        public string Address { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public int Sum { get; set; }
    }
}

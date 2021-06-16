using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Models.Goods
{
    public class CommentModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public Guid GoodsId { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
    }
}

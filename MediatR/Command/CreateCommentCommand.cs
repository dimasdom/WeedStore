using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class CreateCommentCommand:IRequest<bool>
    {
        public CreateCommentCommand(string userName, Guid goodsId, string commentText)
        {
            UserName = userName;
            GoodsId = goodsId;
            CommentText = commentText;
        }

        public string UserName { get; set; }
        public Guid GoodsId { get; set; }
        public string CommentText { get; set; }
    }
}

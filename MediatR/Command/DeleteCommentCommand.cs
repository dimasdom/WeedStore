using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.MediatR.Command
{
    public class DeleteCommentCommand:IRequest<bool>
    {
        public DeleteCommentCommand(Guid commentId)
        {
            CommentId = commentId;
        }

        public Guid CommentId { get; set; }
    }
}

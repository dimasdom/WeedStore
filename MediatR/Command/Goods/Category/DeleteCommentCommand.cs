using MediatR;
using System;

namespace WeedStore.MediatR.Command
{
    public class DeleteCommentCommand : IRequest<bool>
    {
        public DeleteCommentCommand(Guid commentId)
        {
            CommentId = commentId;
        }

        public Guid CommentId { get; set; }
    }
}

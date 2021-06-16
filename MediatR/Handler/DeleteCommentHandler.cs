using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;

namespace WeedStore.MediatR.Handler
{
    public class DeleteCommentHandler : IRequestHandler<DeleteCommentCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public DeleteCommentHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.FindAsync(request.CommentId);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

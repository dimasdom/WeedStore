using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public CreateCommentHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new CommentModel { CommentText = request.CommentText, UserName = request.UserName, GoodsId = request.GoodsId,Date=DateTime.Now };
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}

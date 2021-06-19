using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class GetCommentsHandler : IRequestHandler<GetCommentsQuery, List<CommentModel>>
    {
        private readonly WeedStoreContext _context;

        public GetCommentsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<List<CommentModel>> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
        {
            var comments = _context.Comments.Where(x => x.GoodsId == request.GoodsId).ToList();
            return comments;
        }
    }
}

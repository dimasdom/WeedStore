using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Query;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, List<CategoryModel>>
    {
        private readonly WeedStoreContext _context;

        public GetCategoriesHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories =  _context.Categories.ToList();
            return categories;
        }
    }
}

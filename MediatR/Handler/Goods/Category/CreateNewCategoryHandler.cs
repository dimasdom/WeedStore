using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Handler
{
    public class CreateNewCategoryHandler : IRequestHandler<CreateNewCategoryCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public CreateNewCategoryHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(CreateNewCategoryCommand request, CancellationToken cancellationToken)
        {
            CategoryModel newCategory = new CategoryModel { Name = request.Name };
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}

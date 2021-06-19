using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;

namespace WeedStore.MediatR.Handler
{
    public class ChangeOrderStatusHandler : IRequestHandler<ChangeOrderStatusCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public ChangeOrderStatusHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ChangeOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var Order = await _context.Orders.FindAsync(request.OrderId);
            Order.Status = request.NewStatus;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

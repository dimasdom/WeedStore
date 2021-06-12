using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.Context;
using WeedStore.Models.User;

namespace WeedStore.MediatR.Handler
{
    public class CreateGoodsHandler : IRequestHandler<CreateGoodsCommand, bool>
    {
        private readonly WeedStoreContext _context;

        public CreateGoodsHandler(WeedStoreContext context)
        {
            _context = context;
        }

        public  Task<bool> Handle(CreateGoodsCommand request, CancellationToken cancellationToken)
        {
            _context.Goods.Add(request.Goods);
              _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}

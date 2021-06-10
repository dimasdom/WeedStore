
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.Models.User;
using WeedStore.Models.Goods;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WeedStore.Models.Context
{
    public class WeedStoreContext:IdentityDbContext<UserModel>
    {
        public WeedStoreContext(DbContextOptions<WeedStoreContext> options): base(options)
        {
        }

        public DbSet<GoodsModel> Goods { get; set; }
    }
}
